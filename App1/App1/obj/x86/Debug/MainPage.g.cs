﻿#pragma checksum "C:\Users\Admin\source\repos\xopero\App1\App1\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "017076CAE71289865A11F12507218DABF5002547F19B26FC4DBE407DEEDDFC41"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 4: // MainPage.xaml line 16
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // MainPage.xaml line 27
                {
                    this.startButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.startButton).Click += this.startButton_Click;
                }
                break;
            case 6: // MainPage.xaml line 28
                {
                    this.progressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 7: // MainPage.xaml line 29
                {
                    this.playArea = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.playArea).PointerMoved += this.playArea_PointerMoved;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.playArea).PointerExited += this.playArea_PointerExited;
                }
                break;
            case 8: // MainPage.xaml line 44
                {
                    this.human = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.human).PointerPressed += this.human_PointerPressed;
                }
                break;
            case 9: // MainPage.xaml line 48
                {
                    this.gameOverText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 49
                {
                    this.target = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 11: // MainPage.xaml line 46
                {
                    this.rectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.rectangle).PointerEntered += this.rectangle_PointerEntered;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

