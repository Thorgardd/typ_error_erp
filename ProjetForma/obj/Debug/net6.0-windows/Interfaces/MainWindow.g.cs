﻿#pragma checksum "..\..\..\..\Interfaces\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86F29A9FEA243C30DBE25FBA35374664AAE02F3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetForma;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProjetForma {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\Interfaces\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonUser;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Interfaces\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonModerate;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Interfaces\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCanal;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Interfaces\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Quit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjetForma;component/interfaces/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Interfaces\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ButtonUser = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.ButtonUser.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonUser_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.ButtonUser.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonUser_OnMouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonModerate = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.ButtonModerate.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonModerate_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.ButtonModerate.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonModerate_OnMouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonCanal = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.ButtonCanal.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ButtonCanal_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.ButtonCanal.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonCanal_OnMouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Quit = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.Quit.Click += new System.Windows.RoutedEventHandler(this.Quit_Click);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.Quit.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Quit_MouseEnter);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\..\Interfaces\MainWindow.xaml"
            this.Quit.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Quit_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

