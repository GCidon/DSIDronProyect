﻿#pragma checksum "C:\Users\mxddx\source\repos\DronProyect\DronProyect\Config.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E7011626810BE79151F9A9EBBD83903"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DronProyect
{
    partial class Config : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Config.xaml line 78
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.backtoMain;
                }
                break;
            case 3: // Config.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.mandoButton;
                }
                break;
            case 4: // Config.xaml line 41
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.tecladoButton;
                }
                break;
            case 5: // Config.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.hudButton;
                }
                break;
            case 6: // Config.xaml line 55
                {
                    this.mando = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // Config.xaml line 56
                {
                    this.teclado = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // Config.xaml line 57
                {
                    this.hudImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // Config.xaml line 60
                {
                    this.hud = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10: // Config.xaml line 63
                {
                    this.slider1 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 11: // Config.xaml line 66
                {
                    this.slider2 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 12: // Config.xaml line 69
                {
                    this.slider4 = (global::Windows.UI.Xaml.Controls.Slider)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
