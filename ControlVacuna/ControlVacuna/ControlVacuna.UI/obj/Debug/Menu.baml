   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI   ControlVacuna.UI.Menu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	     � Title$
  Menu��5   	   
�������$��669.936��6*   $��1364.738��6;    � WindowStartupLocation$ CenterScreen=�6L    � WindowState$ 	Maximized=�6q    � Icon$ imgs/Medicina.png��6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      �  J� RenderTransformOrigin$ 0.483,0.487&�6   .+�5   
   !   MahApps.Metro.Controls.Tile  -   5          Name$ btnAyuda��5      
����� �$��1132,12,45,477q�6A   $
��Auto��6Y   $
��Auto��6g   	   Title$	 ¿Ayuda?��6t   
   TitleFontSize$
 20��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5      �� $��imgs/ayuda.png��6   $	��141��6,   $ 0.537,0.356&�69   5        5    
   -   5        $ btnSalir��5    I      MetroCircleButtonStyle#���   6   
����� �$��1106,462,45,24q�6q   $
��Auto��6�   $
��Auto��6�   $	 Salir��6�    5!        5"      .��5$      �� $��imgs/Logout.png��6   $	��141��6-   $ 0.537,0.356&�6:   $	��153��6^   5%        5&   
   -   5        $ btnModificarVcuna��5&      
����� �$��523,465,578,24q�6J   $
��Auto��6b   $
��Auto��6p   $	 Mofificar/Eliminar vacuna��6}    5'        5(      .��5*      �� $��imgs/Injection2.png��6   $	��163��61   $ 0.537,0.356&�6>   5+        5,   
   -   5        $ btnAgregarVacuna��5,      
����� �$��523,238,579,251q�6I   $
��Auto��6b   $
��Auto��6p   $	 Agregar Vacuna��6}    5-        5.      .��50      �� $��imgs/add.png��6   $	��136��6*   $ 0.537,0.356&�67   $	��124��6[   6i   51        52   
   -   5        $ btnAgregarFrasco��52      
����� �$��820,238,282,26q�6I   $
��Auto��6a   $
��Auto��6o   $	 Agregar Frasco��6|    53        54      .��56      �� $��imgs/AgregarFrasco.png��6   $	��136��64   $ 0.537,0.356&�6A   $	��124��6e   57        58   
   -   5        $ btnEliModFrasco��58      
����� �$��824,10,282,479q�6H   $
��Auto��6`   $
��Auto��6n   $	 Modificar/Eliminar frasco��6{    59        5:      .��5<      �� $��imgs/frasco.png��6   $	��136��6-   $ 0.537,0.356&�6:   $	��124��6^   5=        5>   
   -   5        $ btnBuscarFrasco��5>      
����� �$��1132,238,45,266q�6H   $
��Auto��6a   $
��Auto��6o   $	 Buscar frasco��6|    5?        5@      .��5B      �� $��imgs/encontrarFrasco.png��6   $	��136��66   $ 0.537,0.356&�6C   $	��124��6g   5C      #   MahApps.Metro.Controls.Flyout  5D   
   -   5          Name$ FlyRegistrar��5D      $	��347��60   
�������   Header$ Registrar usuario��6O      Position$ Right=�6j      Theme$ Light=�6{   ��5E      �� 5F       �� Color$ 	#FF252424��6"    �� Opacity$	 0.8Q�64   5G      .��5I      �� .+�5J      �� $
��Fill=�6   $��imgs/registrar.png��6'    �� Left$ 56��6C   
 �� Top$	 -16��6T   $	��196��6e   $	��234��6r   �� 5K      -	   5         ��Name$ 	txtNombre��5K      $ 41��6-   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Escriba nombre��6>   $	��Top=�6p   $	��277��6�   $	 166��6�   �� 5L      -
   5        $ txtApellido��5L      $ 41��6/   $ Escriba apellido��6@   $	��Top=�6t   $	��277��6�   $	 210��6�   �� 5M      -   5        $ txtNick��5M      $ 41��6+   $ Escriba nick��6<   $	��Top=�6l   $	��277��6�   $	 255��6�   G� 5N      -   5         G�Name$ txtPass��5N      $ 41��60   $ Escriba Contraseña��6A   $	 299��6w   $��20��6�   $	��277��6�   G� 5O      -   5        $ txtConfirmar��5O      $ 41��64   $ Repita contraseña��6E   $	 344��6z   $��20��6�   $	��277��6�   �� 5P      -   5         ��Name$ btnAgregarAdmin��5P      $��Agregar usuario��62   $ 41��6L   $	 420��6]   $��38��6n   $	��277��6z   $��12(�6�   6�   5Q      5R        5T   
   -   5        $ btnRegistrar��5T      
����� �$��25,10,1150,479q�6E   $
��Auto��6]   $
��Auto��6k   $	 Registrarse��6x   $
 20��6�    5U        5V      .��5X      �� $��imgs/registrar.png��6   $	��141��60   $ 0.537,0.356&�6=   5Y        5Z   
   -   5        $ btnBuscarVacuna��5Z      
����� �$��248,465,853,24q�6H   $
��Auto��6`   $
��Auto��6n   $	 Buscar Vacuna��6{    5[        5\      .��5^      �� $��imgs/find.png��6   $	��136��6+   $ 0.537,0.356&�68   $	��118��6\   5_        5`   
   -   5        $ btnBuscarUsuario��5`      
����� �$��248,238,853,251q�6I   $
��Auto��6b   $
��Auto��6p   $	 Buscar Usuario��6}    5a        5b      .��5d      �� $��imgs/find_user.png��6   $	��136��60   $ 0.537,0.356&�6=   $	��118��6a   5e        5f   
   -   5        $ btnModificarAdministrador��5f      
����� �$��248,10,853,479q�6R   $
��Auto��6j   $
��Auto��6x   $ 	 Modificar/Eliminar Usuario��6�    5g        5h      .��5j      �� $��imgs/admin.png��6   $	��136��6,   $ 0.537,0.356&�69   $	��153��6]   5k        5l   
   -   5        $ btnAgregarPaciente��5l      
����� �$��25,465,1150,24q�6K   $
��Auto��6c   $
��Auto��6q   $	 Ag. Paciente��6~   $
 20��6�    5m        5n      .��5p      �� $��imgs/Agregar-paciente.png��6   $	��125��67   $ 0.537,0.356&�6D   5q        5r   
   -   5        $ btnModificarPaciente��5r      
����� �$��523,12,578,477q�6M   $
��Auto��6e   $
��Auto��6s   $!	 Modificar/Eliminar Paciente��6�    5s        5t      .��5v      �� $��imgs/Paciente.png��6   $	��136��6/   $ 0.537,0.356&�6<   $	��153��6`   5w        5x   
   -   5        $ btnBuscarPaciente��5x      
����� �$��25,240,1150,249q�6J   $
��Auto��6c   $
��Auto��6q   $	 Busc. Paciente��6~   $
 20��6�    5y        5z      .��5|      �� $!��imgs/Encontrar-paciente.png��6   $	��125��69   $ 0.537,0.356&�6F   5}      5      5�      