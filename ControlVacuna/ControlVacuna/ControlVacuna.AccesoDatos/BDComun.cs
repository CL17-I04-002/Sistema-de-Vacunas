using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVacuna.AccesoDatos
{
    public class BDComun
    {
        private static BDControlVacunaEntities _contexto;

        public static BDControlVacunaEntities Contexto
        {
            get
            {
                if (_contexto == null)
                {
                    _contexto = new BDControlVacunaEntities();
                }
                return _contexto;
            }
        }
    }
    }
