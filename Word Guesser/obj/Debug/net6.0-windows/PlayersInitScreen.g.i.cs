﻿#pragma checksum "..\..\..\PlayersInitScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A01D25E4CDC59D82835732BF83E1A5DF83073B5F"
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
    /// PlayersInitScreen
    /// </summary>
    public partial class PlayersInitScreen : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\PlayersInitScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PlayerInitGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\PlayersInitScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TBD;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\PlayersInitScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToPlayerNumberButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Word Guesser;V1.0.0.0;component/playersinitscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PlayersInitScreen.xaml"
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
            this.PlayerInitGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TBD = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BackToPlayerNumberButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\PlayersInitScreen.xaml"
            this.BackToPlayerNumberButton.Click += new System.Windows.RoutedEventHandler(this.BackToPlayerNumberButton_Click);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\PlayersInitScreen.xaml"
            this.BackToPlayerNumberButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.BackToPlayerNumberButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\PlayersInitScreen.xaml"
            this.BackToPlayerNumberButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackToPlayerNumberButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

