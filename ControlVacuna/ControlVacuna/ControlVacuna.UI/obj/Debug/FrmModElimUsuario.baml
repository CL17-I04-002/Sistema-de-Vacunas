   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI(   "ControlVacuna.UI.FrmModElimUsuario   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   -   5          � Title$$  Mantenimiento de Administrador��5   	   $��446.256��60   
����� �$��711.237��6[    � WindowStartupLocation$ CenterScreen=�6k    � Icon$ imgs/admin.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $	��Id:��6   $
��Left=�6   $��	46,43,0,0q�69   $��11(�6L   $	��Top=�6Z   $��	Castellar)�6r   �� 5   
   $��Nombre:��6   $
��Left=�6"   $��	46,99,0,0q�6=   $��11(�6P   $	��Top=�6^   $��	Castellar)�6v   �� 5   
   $��	Apellido:��6   $
��Left=�6$   $��
46,169,0,0q�6?   $��11(�6S   $	��Top=�6a   $��	Castellar)�6y   �� 5   
   -   5         ��Name$ txtApellido��5   *   
���i��$
��Left=�6?   $��23��6Z   $��132,166,0,0q�6f    �� TextWrapping$
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��160��6�   .��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5       5!      �� 5"   
   -   5        $ 	txtNombre��5"   *   
���i��$
��Left=�6=   $��26��6X   $��
132,99,0,0q�6d   $
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��160��6�   .��6�    5#        5$      .��5%      5&      �� 5'   
   -   5        $ txtId��5'   *   
���i��$
��Left=�69   $��23��6T   $��
132,43,0,0q�6`   $
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $��92��6�   .��6�    5(        5)      .��5*      5+      �� 5,   
   $��Nick:��6   $
��Left=�6    $��
344,43,0,0q�6;   $��11(�6O   $	��Top=�6]   $��	Castellar)�6u   �� 5-   
   $��Contraseña:��6   $
��Left=�6&   $��344,109,0,0q�6A   $��11(�6V   $	��Top=�6d   $��	Castellar)�6|   �� 5.   
   $��
Confirmar:��6   $
��Left=�6%   $��351,166,0,0q�6@   $��11(�6U   $	��Top=�6c   $��	Castellar)�6{   �� 5/   
   -   5        $ txtNick��5/   *   
���i��$
��Left=�6;   $��23��6V   $��
472,43,0,0q�6b   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��128��6�   .��6�    50        51      .��52      53      �� 54   
   -   5        	 ��Name$	 btnModificar��54      $�� ��6'   $
��Left=�62   $��316,311,0,0q�6M   $	��Top=�6b   $��94��6z   $��68��6�   ��55      �� 56      
 �� ImageSource$
 imgs/modificar_admin.png��6   58      �� 59   
   -   5        $	 btnEliminar��59      $
��Left=�6&   $��508,311,0,0q�6A   $	��Top=�6V   $��92��6n   $��67��6y   ��5:      �� 5;      $
 imgs/eliminar_admin.png��6   5=      �� 5>   
   -   5        $	 	btnBuscar��5>      $�� ��6$   $
��Left=�6/   $��126,310,0,0q�6J   $	��Top=�6_   $��94��6w   $��68��6�   ��5?      �� 5@      $
 imgs/encontrar_admin.png��6   5B      G� 5C   
   -	   5         G�Name$ txtPass��5C   �   *   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Escriba Contraseña��6D   
���i��$
��Left=�6�   $��473,106,0,0q�6�   $	��Top=�6�   $	��185��6�    5D        5E      5G      G� 5H   
   -
   5        $ txtConfirmar��5H   �    . $ Confirmar Contraseña��6D   
���i��$
��Left=�6�   $��472,166,0,0q�6�   $	��Top=�6�   $	��186��6�    5I        5J      5L      5N      5O      