﻿#pragma checksum "C:\Users\Lokesh Basu\Documents\Visual Studio 2012\Projects\Khai-Khai_New\Khai-Khai_New\Winner.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F3E53E19D095446D6ECB70743D3FC23F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Khai_Khai_New {
    
    
    public partial class Winner : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock Winner1;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock WinnerName;
        
        internal System.Windows.Controls.Button PlayAgain;
        
        internal System.Windows.Controls.Image WinnerImage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Khai-Khai_New;component/Winner.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Winner1 = ((System.Windows.Controls.TextBlock)(this.FindName("Winner1")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.WinnerName = ((System.Windows.Controls.TextBlock)(this.FindName("WinnerName")));
            this.PlayAgain = ((System.Windows.Controls.Button)(this.FindName("PlayAgain")));
            this.WinnerImage = ((System.Windows.Controls.Image)(this.FindName("WinnerImage")));
        }
    }
}

