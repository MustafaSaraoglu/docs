﻿#pragma checksum "..\..\Page1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "240AF736D037AD7A1E1EF65C522EFD18548601A29DEEFBDA5704322A9D6601F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Input_Ovw {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel mainStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/Input_Ovw;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
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
            
            #line 4 "..\..\Page1.xaml"
            ((Input_Ovw.Page1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 9 "..\..\Page1.xaml"
            ((System.Windows.Controls.StackPanel)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.OnOverviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 10 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnOverviewButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.OnButtonKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 26 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnMouseExampleMouseEnter);
            
            #line default
            #line hidden
            
            #line 27 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnMosueExampleMouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 34 "..\..\Page1.xaml"
            ((System.Windows.Controls.StackPanel)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.OnTextInputKeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 35 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnTextInputButtonClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 43 "..\..\Page1.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.handler1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 52 "..\..\Page1.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.handler2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
