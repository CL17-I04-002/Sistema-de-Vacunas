   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI'   !ControlVacuna.UI.FrmAgregarVacuna   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6Y   9Custom,http://metro.mahapps.com/winfx/xaml/controls   6�   Jcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro   5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   -   5          � Title$  Agregar Vacuna��5   	   
����� �$��479.648��6:   $��547.818��6K    � WindowStartupLocation$ CenterScreen=�6[    � Icon$ imgs/add.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5
      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $��Fecha:��6   $
��Left=�6!   $��	37,45,0,0q�6<   $	��Top=�6O   $��	Castellar)�6g   �� 5   
   $��	Cantidad:��6   $
��Left=�6$   $��
37,101,0,0q�6?   $	��Top=�6S   $��	Castellar)�6k   �� 5   
   -   5         ��Name$ txtCantidad��5   R   
���i��*   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$
 0.00��6*   $
��Left=�6g   $��23��6�   $��
203,99,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��75��6�   .��6  	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5      5      �� 5    
   $��Descripcion:��6   $
��Left=�6'   $��
37,209,0,0q�6B   $	��Top=�6V   $��	Castellar)�6n   �� 5!   
   -   5        
 ��Name$
 
btnGuardar��5!      $�� ��6%   $
��Left=�60   $��117,340,0,0q�6K   $	��Top=�6`   $��94��6x   $��67��6�   ��5"      �� 5#       �� ImageSource$ imgs/save2.png��6   5%      �� 5&   
   -   5        $
 btnSalir��5&      $
��Left=�6#   $��320,340,0,0q�6>   $	��Top=�6S   $��93��6k   $��67��6v   ��5'      �� 5(      $ imgs/exit2.png��6   5*      (  "System.Windows.Controls.DatePicker  5+   
   -   5          Name$ dpFecha��5+      
���i��$
��Left=�6?   $��
203,43,0,0q�6Z   $	��Top=�6n   $	��244��6�   	 5,        5-      5/      �� 50   
   -   5        $ txtDescripcion��50   *   
���i��$
��Left=�6B   $��86��6]   $��203,209,0,0q�6i   $
 Wrap=�6~   $�� ��6�   $	��Top=�6�   $	��244��6�   .��6�   	 51        52      .��53      54      �� 55   
   $��CC��6   $
��Left=�6   $��292,101,0,0q�68   $	��Top=�6M   $��	Castellar)�6e   �� 56   
   $��Nombre de paciente:��6   $
��Left=�6.   $��
37,150,0,0q�6I   $	��Top=�6]   $��	Castellar)�6u   �� 57   
   -   5        $ txtNombrePacient��57   *   
���i��$
��Left=�6D   $��24��6_   $��203,148,0,0q�6k   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��176��6�   .��6�   	 58        59      .��5:      5;      �� 5<   
   -   5        $
 btnBuscarPacient��5<      $�� ��6+   $
��Left=�66   $��396,148,0,0q�6Q   $	��Top=�6f   $��51��6~   $��28��6�   ��5=      �� 5>      $ imgs/encontrar.png��6   5@      5B      5C      