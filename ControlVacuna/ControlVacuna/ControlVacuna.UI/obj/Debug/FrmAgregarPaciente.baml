   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI)   #ControlVacuna.UI.FrmAgregarPaciente   5      Hcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5   	   -   5          � Title$  FrmAgregarPaciente��5   	   
����� � � WindowStartupLocation$ CenterScreen=�6=   $��489.224��6b   $��699.433��6s    � Icon$ imgs/Agregar-paciente.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $��Nombre:��6   $
��Left=�6"   $��
174,58,0,0q�6=   $	��Top=�6Q   $��	Castellar)�6i   �� 5   
   $��	Apellido:��6   $
��Left=�6$   $��168,107,0,0q�6?   $	��Top=�6T    J� RenderTransformOrigin$ -0.321,0.338&�6l   $��	Castellar)�6�   �� 5   
   $��Edad:��6   $
��Left=�6    $��174,157,0,0q�6;   $	��Top=�6P   $��	Castellar)�6h   $ 
1.27,0.521&�6   �� 5   
   -   5         ��Name$ 	txtNombre��5   *   
���i��$
��Left=�6=   $��23��6X   $��
310,59,0,0q�6d    �� TextWrapping$
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��231��6�   .��6�   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5      5       �� 5!   
   -   5        $ txtApellido��5!   *   
���i��$
��Left=�6?   $��23��6Z   $��310,107,0,0q�6f   $
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��231��6�   .��6�   	 5"        5#      .��5$      5%      �� 5&   
   -   5        $ txtEdad��5&   *   
���i��$
��Left=�6;   $��23��6V   $��310,155,0,0q�6b   $
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $	��185��6�   .��6�   	 5'        5(      .��5)      5*      �� 5+   
   $��
Direccion:��6   $
��Left=�6%   $��174,211,0,0q�6@   $	��Top=�6U   $��	Castellar)�6m   �� 5,   
   -   5        $ txtDireccion��5,   *   
���i��$
��Left=�6@   $��97��6[   $��310,211,0,0q�6g   $
 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��231��6�   .��6�   	 5-        5.      .��5/      50      �� 51   
   -   5        
 ��Name$
 
btnGuardar��51      $�� ��6%   $
��Left=�60   $��196,365,0,0q�6K   $	��Top=�6`   $��94��6x   $��67��6�   ��52      �� 53       �� ImageSource$ imgs/Save.png��6   55      �� 56   
   -   5        $
 btnSalir��56      $
��Left=�6#   $��402,365,0,0q�6>   $	��Top=�6S   $��93��6k   $��67��6v   ��57      �� 58      $ imgs/Close.png��6   5:      5<      5=      