﻿#pragma checksum "..\..\FrmModElimPaciente.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3249AD7D09114F83DDD8D20386CF634D"
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
    /// FrmModElimPaciente
    /// </summary>
    public partial class FrmModElimPaciente : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellido;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEdad;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\FrmModElimPaciente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
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
            System.Uri resourceLocater = new System.Uri("/ControlVacuna.UI;component/frmmodelimpaciente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FrmModElimPaciente.xaml"
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
            
            #line 6 "..\..\FrmModElimPaciente.xaml"
            ((ControlVacuna.UI.FrmModElimPaciente)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtEdad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\FrmModElimPaciente.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\FrmModElimPaciente.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\FrmModElimPaciente.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.btnBuscar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
