﻿#pragma checksum "..\..\BuscarAdministrador.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1E98E4A814417D72F7C1E7CBF3C23E58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ControlVacuna.UI {
    
    
    /// <summary>
    /// BuscarAdministrador
    /// </summary>
    public partial class BuscarAdministrador : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\BuscarAdministrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreAdmin;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\BuscarAdministrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscarAdmin;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\BuscarAdministrador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAdmin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ControlVacuna.UI;component/buscaradministrador.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BuscarAdministrador.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\BuscarAdministrador.xaml"
            ((ControlVacuna.UI.BuscarAdministrador)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded_2);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNombreAdmin = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\BuscarAdministrador.xaml"
            this.txtNombreAdmin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNombreAdmin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnBuscarAdmin = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.dgAdmin = ((System.Windows.Controls.DataGrid)(target));
            
            #line 41 "..\..\BuscarAdministrador.xaml"
            this.dgAdmin.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgAdmin_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
