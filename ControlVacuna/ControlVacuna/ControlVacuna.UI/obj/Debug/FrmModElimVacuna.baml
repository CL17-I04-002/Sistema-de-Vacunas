   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI'   !ControlVacuna.UI.FrmModElimVacuna   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   -   5          � Title$  Mantenimiento de Vacuna��5   	   
����� � � WindowStartupLocation$ CenterScreen=�6B   $��446.256��6g   $��783.237��6x    � Icon$ imgs/Injection2.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $	��Id:��6   $
��Left=�6   $��	46,43,0,0q�69   $��11(�6L   $	��Top=�6Z   $��	Castellar)�6r   �� 5   
   $��Fecha:��6   $
��Left=�6!   $��
46,128,0,0q�6<   $��11(�6P   $	��Top=�6^   $��	Castellar)�6v   �� 5   
   $��Descripción:��6   $
��Left=�6'   $��368,128,0,0q�6B   $��11(�6W   $	��Top=�6e   $��	Castellar)�6}   �� 5   
   -   5         ��Name$ txtDescripcion��5   *   
���i��$
��Left=�6B   $��86��6]   $��481,112,0,0q�6i    �� TextWrapping$
 Wrap=�6~   $�� ��6�   $	��Top=�6�   $	��244��6�   .��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5       5!      �� 5"   
   -   5        $ txtId��5"   *   
���i��$
��Left=�69   $��23��6T   $��
109,40,0,0q�6`   $
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $��92��6�   .��6�    5#        5$      .��5%      5&      �� 5'   
   $��	Cantidad:��6   $
��Left=�6$   $��
382,46,0,0q�6?   $��11(�6S   $	��Top=�6a   $��	Castellar)�6y   �� 5(   
   -   5        $ txtCantidad��5(   *   
���i��*   $MahApps.Metro.Controls.TextBoxHelper	   	Watermark$
	 0.00��6?   $
��Left=�6g   $��23��6�   $��
481,43,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��75��6�   .��6   5)        5*      .��5+      5,      �� 5-   
   -   5        
 ��Name$
 btnModificar��5-      $�� ��6'   $
��Left=�62   $��316,311,0,0q�6M   $	��Top=�6b   $��94��6z   $��68��6�   ��5.      �� 5/       �� ImageSource$ imgs/actualizar.png��6   51      �� 52   
   -   5        $
 btnEliminar��52      $
��Left=�6&   $��508,311,0,0q�6A   $	��Top=�6V   $��92��6n   $��67��6y   ��53      �� 54      $ imgs/eliminar.png��6   56      �� 57   
   -   5        $
 	btnBuscar��57      $�� ��6$   $
��Left=�6/   $��126,310,0,0q�6J   $	��Top=�6_   $��94��6w   $��68��6�   ��58      �� 59      $ imgs/encontrar.png��6   5;      (  "System.Windows.Controls.DatePicker  5<   
   -   5          Name$ dpFecha��5<      
���i��$
��Left=�6?   $��109,128,0,0q�6Z   $	��Top=�6o   $	��190��6�    5=        5>      5@      �� 5A   
   $��CC��6   $
��Left=�6   $��
571,46,0,0q�68   $	��Top=�6L   $��	Castellar)�6d   �� 5B   
   $��	Paciente:��6   $
��Left=�6$   $��
27,206,0,0q�6?   $��11(�6S   $	��Top=�6a   $��	Castellar)�6y   �� 5C   
   -	   5        $ txtNombrePacient��5C   *   
���i��$
��Left=�6D   $��23��6_   $��109,203,0,0q�6k   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��190��6�   .��6�    5D        5E      .��5F      5G      �� 5H   
   -
   5        $
 btnBuscarPacient��5H      $�� ��6+   $
��Left=�66   $��316,206,0,0q�6Q   $	��Top=�6f   $��51��6~   $��28��6�   ��5I      �� 5J      $ imgs/encontrar.png��6   5L      5N      5O      