﻿#pragma checksum "..\..\..\..\Windows\ReturnBookWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "856295DECB6011160B4B88A4BF58A9BE5518790A"
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
using cs_finalproject.Windows;


namespace cs_finalproject.Windows {
    
    
    /// <summary>
    /// ReturnBookWindow
    /// </summary>
    public partial class ReturnBookWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblReturnCustomerName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtReturnCustomerName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSearchReturnCustomer;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblCustomerName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblBookName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblManegerName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblStartDay;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblFind;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Windows\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblEndDay;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/cs finalproject;component/windows/returnbookwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\ReturnBookWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LblReturnCustomerName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtReturnCustomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnSearchReturnCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Windows\ReturnBookWindow.xaml"
            this.BtnSearchReturnCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnSearchReturnCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LblCustomerName = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.LblBookName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.LblManegerName = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.LblStartDay = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.LblFind = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 32 "..\..\..\..\Windows\ReturnBookWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LblEndDay = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

