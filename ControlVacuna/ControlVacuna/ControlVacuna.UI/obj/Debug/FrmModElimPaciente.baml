   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI)   #ControlVacuna.UI.FrmModElimPaciente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5   	   -   5          � Title$  FrmModElimPaciente��5   	   
����� � � WindowStartupLocation$ CenterScreen=�6=   $��421.845��6b   $��664.659��6s    � Icon$ imgs/Paciente.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $	��Id:��6   $
��Left=�6   $��	37,25,0,0q�69   $��11(�6L   $	��Top=�6Z   $��	Castellar)�6r   �� 5   
   $��Nombre:��6   $
��Left=�6"   $��	37,81,0,0q�6=   $��11(�6P   $	��Top=�6^   $��	Castellar)�6v   �� 5   
   $��	Apellido:��6   $
��Left=�6$   $��
37,151,0,0q�6?   $��11(�6S   $	��Top=�6a   $��	Castellar)�6y   �� 5   
   -   5         ��Name$ txtApellido��5   *   
���i��$
��Left=�6?   $��23��6Z   $��123,148,0,0q�6f    �� TextWrapping$
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��160��6�   .��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5      5       �� 5!   
   -   5        $ 	txtNombre��5!   *   
���i��$
��Left=�6=   $��26��6X   $��
123,81,0,0q�6d   $
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��160��6�   .��6�    5"        5#      .��5$      5%      �� 5&   
   -   5        $ txtId��5&   *   
���i��$
��Left=�69   $��23��6T   $��
123,25,0,0q�6`   $
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $��92��6�   .��6�    5'        5(      .��5)      5*      �� 5+   
   $��Edad:��6   $
��Left=�6    $��
324,64,0,0q�6;   $��11(�6O   $	��Top=�6]   $��	Castellar)�6u   �� 5,   
   -   5        $ txtEdad��5,   *   
���i��$
��Left=�6;   $��23��6V   $��
452,64,0,0q�6b   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��128��6�   .��6�    5-        5.      .��5/      50      �� 51   
   $��Dirección:��6   $
��Left=�6%   $��324,120,0,0q�6@   $��11(�6U   $	��Top=�6c   $��	Castellar)�6{   �� 52   
   -   5        $ txtDireccion��52   *   
���i��$
��Left=�6@   $��70��6[   $��452,120,0,0q�6g   $
 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��166��6�   .��6�    53        54      .��55      56      �� 57   
   -   5        	 ��Name$	 btnModificar��57      $�� ��6'   $
��Left=�62   $��296,284,0,0q�6M   $	��Top=�6b   $��94��6z   $��68��6�   ��58      �� 59      
 �� ImageSource$
 imgs/refresh-pacient.png��6   5;      �� 5<   
   -   5        $	 btnEliminar��5<      $
��Left=�6&   $��488,284,0,0q�6A   $	��Top=�6V   $��92��6n   $��67��6y   ��5=      �� 5>      $
 imgs/Delete-pacient.png��6   5@      �� 5A   
   -	   5        $	 	btnBuscar��5A      $�� ��6$   $
��Left=�6/   $��106,283,0,0q�6J   $	��Top=�6_   $��94��6w   $��68��6�   ��5B      �� 5C      $
 imgs/find-pacient.png��6   5E      5G      5H      