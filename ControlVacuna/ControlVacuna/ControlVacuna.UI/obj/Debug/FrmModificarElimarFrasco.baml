   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI/   )ControlVacuna.UI.FrmModificarElimarFrasco   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   -   5          � Title$  Mantenimiento de Frasco��5   	   
����� � � WindowStartupLocation$ CenterScreen=�6B   $��446.256��6g   $��711.237��6x    � Icon$ imgs/frasco.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $	��Id:��6   $
��Left=�6   $��	34,46,0,0q�69   $��11(�6L   $	��Top=�6Z   $��	Castellar)�6r   �� 5   
   -   5         ��Name$ txtId��5   *   
���i��$
��Left=�69   $��23��6T   $��
229,43,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $��92��6�   .��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5      5      �� 5    
   $��Fecha de entrega:��6   $
��Left=�6,   $��
34,118,0,0q�6G   $	��Top=�6[   $��	Castellar)�6s   (  "System.Windows.Controls.DatePicker  5!   
   -   5        	  Name$	 dpFechaEntrega��5!      
���i��$
��Left=�6F   $��229,118,0,0q�6a   $	��Top=�6v   $	��244��6�    5"        5#      5%      �� 5&   
   $��Fecha de finalizacion:��6   $
��Left=�61   $��
34,207,0,0q�6L   $	��Top=�6`   $��	Castellar)�6x     5'   
   -   5        $	 dpFechaFinalizacion��5'      
���i��$
��Left=�6K   $��229,207,0,0q�6f   $	��Top=�6{   $	��244��6�    5(        5)      5+      �� 5,   
   -   5        
 ��Name$
 btnModificar��5,      $�� ��6'   $
��Left=�62   $��316,311,0,0q�6M   $	��Top=�6b   $��94��6z   $��68��6�   ��5-      �� 5.       �� ImageSource$ imgs/actualizar.png��6   50      �� 51   
   -   5        $
 btnEliminar��51      $
��Left=�6&   $��508,311,0,0q�6A   $	��Top=�6V   $��92��6n   $��67��6y   ��52      �� 53      $ imgs/eliminar.png��6   55      �� 56   
   -   5        $
 	btnBuscar��56      $�� ��6$   $
��Left=�6/   $��126,310,0,0q�6J   $	��Top=�6_   $��94��6w   $��68��6�   ��57      �� 58      $ imgs/encontrar.png��6   5:      5<      5=      