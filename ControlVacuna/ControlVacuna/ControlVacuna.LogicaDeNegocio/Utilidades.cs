using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace ControlVacuna.LogicaDeNegocio
{
    public class Utilidades
    {
        public static string EncriptarClave(string pClave)
        {
            string claveEncriptada = "";

            //Declaración de variables para el proceso
            int bytesExtra = 4;
            string claveAEncriptar = pClave;

            //Declaración de un generador de números aleatorios
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            //Declaración de un arreglo de bytes para los bytes extra
            byte[] contenedorBytesExtra = new byte[bytesExtra];

            //Generación de los bytes extra y colocación en el contenedor
            rng.GetNonZeroBytes(contenedorBytesExtra);

            //Convertir la clave digitada por el usuario a arreglo de bytes
            byte[] claveBytes = Encoding.UTF8.GetBytes(claveAEncriptar);

            //Declaración de un arreglo de bytes que contendrá la clave en bytes + los bytes extra
            byte[] claveMasBytesExtra = new byte[claveBytes.Length + contenedorBytesExtra.Length];

            //Copiar los bytes extra y la clave al arreglo claveMasBytesExtra
            Array.Copy(contenedorBytesExtra, 0, claveMasBytesExtra, 0, contenedorBytesExtra.Length);
            Array.Copy(claveBytes, 0, claveMasBytesExtra, contenedorBytesExtra.Length, claveBytes.Length);

            //Creación de la instacia del encriptador mediante Hash
            SHA1CryptoServiceProvider csp = new SHA1CryptoServiceProvider();

            //Declarar un arreglo que contendrá la clave encriptada
            byte[] claveCompletaHash = csp.ComputeHash(claveMasBytesExtra);

            //Declarar un arreglo que contendrá la clave encriptada + los bytes de control
            byte[] claveFinal = new byte[contenedorBytesExtra.Length + claveCompletaHash.Length];

            //Copiar la clave en Hash + los bytes de control al arreglo claveFinal
            Array.Copy(contenedorBytesExtra, 0, claveFinal, 0, contenedorBytesExtra.Length);
            Array.Copy(claveCompletaHash, 0, claveFinal, contenedorBytesExtra.Length, claveCompletaHash.Length);

            //Convertir la clave final a string
            claveEncriptada = Convert.ToBase64String(claveFinal);

            return claveEncriptada;
        }

        public static bool ValidarClave(string pClaveUsuario, string pClaveEncriptada)
        {
            bool aceptado = false;

            //Declarar variables para el proceso
            string claveHash = pClaveEncriptada;
            string claveTecleada = pClaveUsuario;
            int bytesExtra = 4;

            //Convertir la clave en formato Hash a arreglo de bytes
            byte[] claveHashBytes = Convert.FromBase64String(claveHash);

            //Extraer los bytes de control
            int bytesDeControl = BitConverter.ToInt32(claveHashBytes, 0);

            //A la clave encriptada le quitamos los primeros 4 bytes
            byte[] claveSinBytesDeControl = new byte[claveHashBytes.Length - bytesExtra];
            Array.Copy(claveHashBytes, bytesExtra, claveSinBytesDeControl, 0, claveSinBytesDeControl.Length);

            //Convertir la clave digitada por el usuario en la ventana Login a bytes
            byte[] claveDigitadaBytes = Encoding.UTF8.GetBytes(claveTecleada);

            //Convertir los bytes de control a arreglo de bytes
            byte[] bytesExtraBytes = BitConverter.GetBytes(bytesDeControl);

            //Declaración de un arreglo que contendrá los bytes extra en formato de bytes +
            //la clave digitada por el usuario en formato de bytes
            byte[] claveUsuarioMasBytesExtra = new byte[bytesExtraBytes.Length + claveDigitadaBytes.Length];

            //Copiar los bytes extra en formato de bytes y la clave  digitada en formato de bytes
            Array.Copy(bytesExtraBytes, 0, claveUsuarioMasBytesExtra, 0, bytesExtraBytes.Length);
            Array.Copy(claveDigitadaBytes, 0, claveUsuarioMasBytesExtra,
                        bytesExtraBytes.Length, claveDigitadaBytes.Length);

            //Convertir en Hash la clave digitada por el usuario + los bytes de control
            SHA1CryptoServiceProvider csp = new SHA1CryptoServiceProvider();
            byte[] claveDigitadaMasBytesExtraHash = csp.ComputeHash(claveUsuarioMasBytesExtra);

            //Comparar byte por byte la clave digitada con la clave obtenida de la BD
            for (int i = 0; i < claveDigitadaMasBytesExtraHash.Length; i++)
            {
                if (claveDigitadaMasBytesExtraHash[i] != claveSinBytesDeControl[i])
                {
                    aceptado = false;
                    break;
                }
                else
                    aceptado = true;
            }

            return aceptado;
        }
    }
}
