   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI   ControlVacuna.UI.Registro   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   -   5          � Title$  Registro��5   	   
����� � � WindowStartupLocation$ Manual=�63   $��462.406��6S   $��765.857��6d    � Icon$ imgs/login.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $N Hpack://application:,,,/MahApps.Metro;component/Styles/Accents/Brown.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � .+�5   
   �� $��Nombre:��6   $
��Left=�6"   $��
176,20,0,0q�6=   $	��Top=�6Q   $��	Castellar)�6i   �� 5   
   $��	Apellido:��6   $
��Left=�6$   $��
170,69,0,0q�6?   $	��Top=�6S    J� RenderTransformOrigin$ -0.321,0.338&�6k   $��	Castellar)�6�   �� 5   
   $��Nick:��6   $
��Left=�6    $��186,116,0,0q�6;   $	��Top=�6P   $��	Castellar)�6h   �� 5   
   $��Contraseña:��6   $
��Left=�6&   $��159,161,0,0q�6A   $	��Top=�6V   $��	Castellar)�6n   �� 5   
   -   5         ��Name$ 	txtNombre��5   *   
���i��$
��Left=�6=   $��23��6X   $��
312,21,0,0q�6d    �� TextWrapping$
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��231��6�   .��6�   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       .��5!      5"      �� 5#   
   -   5        $ txtApellido��5#   *   
���i��$
��Left=�6?   $��23��6Z   $��
312,69,0,0q�6f   $
 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��231��6�   .��6�   	 5$        5%      .��5&      5'      �� 5(   
   -   5        $ txtNick��5(   *   
���i��$
��Left=�6;   $��23��6V   $��312,117,0,0q�6b   $
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $	��185��6�   .��6�   	 5)        5*      .��5+      5,      G� 5-   
   -   5        
 G�Name$
 txtPass��5-   �   *   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Escriba Contraseña��6D   
���i��$
��Left=�6�   $��312,161,0,0q�6�   $	��Top=�6�   $	��185��6�   	 5.        5/      51      �� 52   
   $��Confirmar Contraseña:��6   $
��Left=�60   $��
90,222,0,0q�6K   $	��Top=�6_   $��	Castellar)�6w   G� 53   
   -   5        $
 txtConfirmar��53   �    . $ Confirmar Contraseña��6D   
���i��$
��Left=�6�   $��311,222,0,0q�6�   $	��Top=�6�   $	��186��6�   	 54        55      57      �� 58   
   -   5         ��Name$ 
btnGuardar��58      $�� ��6%   $
��Left=�60   $��234,341,0,0q�6K   $	��Top=�6`   $��94��6x   $��67��6�   ��59      �� 5:       �� ImageSource$ imgs/Save.png��6   5<      �� 5=   
   -   5        $ btnSalir��5=      $
��Left=�6#   $��450,341,0,0q�6>   $	��Top=�6S   $��93��6k   $��67��6v   ��5>   
   �� 5?      $ imgs/Exit.png��6   5A      5B      5C      