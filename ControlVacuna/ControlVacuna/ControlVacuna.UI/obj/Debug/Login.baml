   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   Z=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	    ControlVacuna.UI   ControlVacuna.UI.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	     � Title$  Inicio de Sesión��5   	   $��482.481��6"   $��532.33��63   
������� � Icon$ imgs/login.png��6V    � WindowStartupLocation$ CenterScreen=�6l    � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   �� 5      $e _pack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedSingleRowTabControl.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatButton.xaml?�6%   �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   %    5      .��5      � -   5        .+�5   
   �� $��Nick:��6   $
��Left=�6    $��106,217,0,0q�6;   $	��Top=�6P   $��	Castellar)�6h   �� 5   
   $��Contraseña:��6   $
��Left=�6&   $��
49,264,0,0q�6A   $	��Top=�6U   $��	Castellar)�6m   �� 5   
   -   5         ��Name$ txtNick��5   +   
���i��$
��Left=�6<   $��23��6W   $��173,218,0,0q�6c    �� TextWrapping$
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��244��6�   .��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5       5!      G� 5"   
   -   5        	 G�Name$	 txtPass��5"   �   *   $MahApps.Metro.Controls.TextBoxHelper
   ClearTextButton
 .    	Watermark$ Escriba Contraseña��6D   
���i��$
��Left=�6�   $��173,262,0,0q�6�   $	��Top=�6�   $	��244��6�    5#        5$      5&      �� 5'   
   $
��Left=�6   $	��175��6+   $��
173,27,0,0q�68   $	��Top=�6L   $	��235��6d   $
��Fill=�6p   $��imgs/login.png��6   �� 5(   
   -   5         ��Name$ btnIniciar_Sesion��5(      $��Iniciar sesion��6,   $
��Left=�6E   $��173,385,0,0q�6`   $	��Top=�6u   $	��244��6�   ���	#FF1706066�   �� 5)   
   -   5        $ btnRegistrar��5)      $��Registrarse��6'   $
��Left=�6=   $��173,346,0,0q�6X   $	��Top=�6m   $	��244��6�   ���	#FF1706066�   5+      5,      