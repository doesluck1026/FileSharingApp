﻿#pragma checksum "..\..\..\Pages\DevicesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02C70CE2D7AB70814F5ADDA96E9C6D3BF26D7676FC92B6EA1EE84201FBA0B669"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FileSharingApp_Desktop.Pages;
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


namespace FileSharingApp_Desktop.Pages {
    
    
    /// <summary>
    /// DevicesPage
    /// </summary>
    public partial class DevicesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\DevicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView list_Devices;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\DevicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Scan;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\DevicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_DeviceIP;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\DevicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Send;
        
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
            System.Uri resourceLocater = new System.Uri("/FileSharingApp_Desktop;component/pages/devicespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DevicesPage.xaml"
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
            this.list_Devices = ((System.Windows.Controls.ListView)(target));
            
            #line 28 "..\..\..\Pages\DevicesPage.xaml"
            this.list_Devices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list_Devices_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Scan = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Pages\DevicesPage.xaml"
            this.btn_Scan.Click += new System.Windows.RoutedEventHandler(this.btn_Scan_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_DeviceIP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_Send = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\DevicesPage.xaml"
            this.btn_Send.Click += new System.Windows.RoutedEventHandler(this.btn_Send_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

