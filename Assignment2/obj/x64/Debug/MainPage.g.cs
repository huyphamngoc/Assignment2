﻿#pragma checksum "C:\Users\Admin\source\repos\Assignment2\Assignment2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1B8AD7E8A2BF6D1E0B194B08062998A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2
{
    partial class MainPage : 
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
            case 2: // MainPage.xaml line 69
                {
                    this.MediaPlayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // MainPage.xaml line 54
                {
                    this.Progress = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 4: // MainPage.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element4 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element4).Click += this.playBack;
                }
                break;
            case 5: // MainPage.xaml line 57
                {
                    this.PlayButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayButton).Click += this.Play_Click;
                }
                break;
            case 6: // MainPage.xaml line 58
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element6 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element6).Click += this.playNext;
                }
                break;
            case 7: // MainPage.xaml line 60
                {
                    this.volumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.volumeSlider).ValueChanged += this.volumeSlider_ValueChanged;
                }
                break;
            case 8: // MainPage.xaml line 61
                {
                    this.volume = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainPage.xaml line 48
                {
                    this.nowPlaying = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 37
                {
                    this.mp4Frame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 11: // MainPage.xaml line 30
                {
                    this.mp3Frame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

