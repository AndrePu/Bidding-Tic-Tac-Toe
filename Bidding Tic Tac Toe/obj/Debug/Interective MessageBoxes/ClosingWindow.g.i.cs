﻿#pragma checksum "..\..\..\Interective MessageBoxes\ClosingWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3CFF67A57D6899CD0670745783A3F08377507F99"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Bidding_Tic_Tac_Toe;
using Microsoft.Expression.Interactivity.Core;
using Microsoft.Expression.Interactivity.Input;
using Microsoft.Expression.Interactivity.Layout;
using Microsoft.Expression.Interactivity.Media;
using Microsoft.Expression.Media.Effects;
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


namespace Bidding_Tic_Tac_Toe {
    
    
    /// <summary>
    /// ClosingWindow
    /// </summary>
    public partial class ClosingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\Interective MessageBoxes\ClosingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Interective MessageBoxes\ClosingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock No_button;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Interective MessageBoxes\ClosingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Yes_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Bidding Tic Tac Toe;component/interective%20messageboxes/closingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interective MessageBoxes\ClosingWindow.xaml"
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
            
            #line 14 "..\..\..\Interective MessageBoxes\ClosingWindow.xaml"
            ((Bidding_Tic_Tac_Toe.ClosingWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.No_button = ((System.Windows.Controls.TextBlock)(target));
            
            #line 52 "..\..\..\Interective MessageBoxes\ClosingWindow.xaml"
            this.No_button.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.No_button_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Yes_button = ((System.Windows.Controls.TextBlock)(target));
            
            #line 70 "..\..\..\Interective MessageBoxes\ClosingWindow.xaml"
            this.Yes_button.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Yes_button_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

