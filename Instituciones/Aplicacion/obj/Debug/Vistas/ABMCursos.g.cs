﻿#pragma checksum "..\..\..\Vistas\ABMCursos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4933BA757549C2EEB5E874458525B97ABF83E6C2BB39956E873CECF57D0C043"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Aplicacion.Vistas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace Aplicacion.Vistas {
    
    
    /// <summary>
    /// ABMCursos
    /// </summary>
    public partial class ABMCursos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Vistas\ABMCursos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblCursos;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Vistas\ABMCursos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrear;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Vistas\ABMCursos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSeleccionar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Vistas\ABMCursos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Vistas\ABMCursos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxCursos;
        
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
            System.Uri resourceLocater = new System.Uri("/Aplicacion;component/vistas/abmcursos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\ABMCursos.xaml"
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
            this.tblCursos = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Vistas\ABMCursos.xaml"
            this.btnCrear.Click += new System.Windows.RoutedEventHandler(this.BtnCrear_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSeleccionar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Vistas\ABMCursos.xaml"
            this.btnSeleccionar.Click += new System.Windows.RoutedEventHandler(this.BtnSeleccionar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Vistas\ABMCursos.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.BtnVolver_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lbxCursos = ((System.Windows.Controls.ListBox)(target));
            
            #line 19 "..\..\..\Vistas\ABMCursos.xaml"
            this.lbxCursos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LbxCursos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

