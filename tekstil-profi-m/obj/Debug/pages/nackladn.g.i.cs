﻿#pragma checksum "..\..\..\pages\nackladn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D946EFCF474CDA4A8743DFC62F5AEC1A7E24DF5F45F55EB182B82505A54DA5ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using tekstil_profi_m.pages;


namespace tekstil_profi_m.pages {
    
    
    /// <summary>
    /// nackladn
    /// </summary>
    public partial class nackladn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\pages\nackladn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\pages\nackladn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowOrderButton;
        
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
            System.Uri resourceLocater = new System.Uri("/tekstil-profi-m;component/pages/nackladn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\nackladn.xaml"
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
            this.lv = ((System.Windows.Controls.ListView)(target));
            
            #line 18 "..\..\..\pages\nackladn.xaml"
            this.lv.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 76 "..\..\..\pages\nackladn.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToOrder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShowOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\pages\nackladn.xaml"
            this.ShowOrderButton.Click += new System.Windows.RoutedEventHandler(this.ShowOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 84 "..\..\..\pages\nackladn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PreviousPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 85 "..\..\..\pages\nackladn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NextPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 86 "..\..\..\pages\nackladn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.userClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

