﻿#pragma checksum "..\..\..\Pages\OptionsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53A6BCF8F7B5F2BDF455948A5A4E10EB1E7422A103393284B066D0E0C6006BF4"
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
using FileSharingApp_Desktop.Properties;
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
    /// OptionsPage
    /// </summary>
    public partial class OptionsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Pages\OptionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_DeviceName;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\OptionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo_Languages;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\OptionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_OutputFolder;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\OptionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SelectFolder;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Pages\OptionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_MainMenu;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Pages\OptionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
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
            System.Uri resourceLocater = new System.Uri("/FileSharingApp_Desktop;component/pages/optionspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\OptionsPage.xaml"
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
            
            #line 11 "..\..\..\Pages\OptionsPage.xaml"
            ((FileSharingApp_Desktop.Pages.OptionsPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Pages\OptionsPage.xaml"
            ((FileSharingApp_Desktop.Pages.OptionsPage)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Page_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_DeviceName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Combo_Languages = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txt_OutputFolder = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_SelectFolder = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\Pages\OptionsPage.xaml"
            this.btn_SelectFolder.Click += new System.Windows.RoutedEventHandler(this.btn_SelectFolder_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_MainMenu = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Pages\OptionsPage.xaml"
            this.btn_MainMenu.Click += new System.Windows.RoutedEventHandler(this.btn_MainMenu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\Pages\OptionsPage.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

