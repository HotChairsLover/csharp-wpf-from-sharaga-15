﻿#pragma checksum "..\..\..\Pages\Scans.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "04535F2551445AD5DD68A6B26EA6ABFF7280D08958F82063133C1FDD56BDF71E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SomeName.Pages;
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


namespace SomeName.Pages {
    
    
    /// <summary>
    /// Scans
    /// </summary>
    public partial class Scans : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\Scans.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chat;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\Scans.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profile;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Scans.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button @continue;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\Scans.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/SomeName;component/pages/scans.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Scans.xaml"
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
            this.chat = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\Scans.xaml"
            this.chat.Click += new System.Windows.RoutedEventHandler(this.OpenChat);
            
            #line default
            #line hidden
            return;
            case 2:
            this.profile = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pages\Scans.xaml"
            this.profile.Click += new System.Windows.RoutedEventHandler(this.OpenProfile);
            
            #line default
            #line hidden
            return;
            case 3:
            this.@continue = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Pages\Scans.xaml"
            this.@continue.Click += new System.Windows.RoutedEventHandler(this.NextPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\Pages\Scans.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.PrevPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

