﻿#pragma checksum "..\..\..\WinnerScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CAE01D8963907F360ADC8661826C6C6BCC9617F9"
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
using Word_Guesser;


namespace Word_Guesser {
    
    
    /// <summary>
    /// WinnerScreen
    /// </summary>
    public partial class WinnerScreen : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\WinnerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ContainerGrid;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\WinnerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CongratsGrid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WinnerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CongratsTextBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\WinnerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid WinnerGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\WinnerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WinnerTextBlock;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\WinnerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ScoresGrid;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\WinnerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MainMenuButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Word Guesser;component/winnerscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WinnerScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ContainerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.CongratsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.CongratsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.WinnerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.WinnerTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ScoresGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.MainMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\WinnerScreen.xaml"
            this.MainMenuButton.Click += new System.Windows.RoutedEventHandler(this.MainMenuButton_Click);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\WinnerScreen.xaml"
            this.MainMenuButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MainMenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\WinnerScreen.xaml"
            this.MainMenuButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MainMenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

