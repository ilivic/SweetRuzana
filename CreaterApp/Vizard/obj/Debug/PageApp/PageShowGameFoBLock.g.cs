﻿#pragma checksum "..\..\..\PageApp\PageShowGameFoBLock.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "251B9C1D7DEF6C4A7340A1C3E77F84879B7904B00829B21FCEE8913F87E25F57"
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
using Vizard.PageApp;


namespace Vizard.PageApp {
    
    
    /// <summary>
    /// PageShowGameFoBLock
    /// </summary>
    public partial class PageShowGameFoBLock : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\PageApp\PageShowGameFoBLock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSerch;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\PageApp\PageShowGameFoBLock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CMBProdactions;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\PageApp\PageShowGameFoBLock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListGame;
        
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
            System.Uri resourceLocater = new System.Uri("/Vizard;component/pageapp/pageshowgamefoblock.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageApp\PageShowGameFoBLock.xaml"
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
            this.TxtSerch = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\PageApp\PageShowGameFoBLock.xaml"
            this.TxtSerch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSerch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CMBProdactions = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\PageApp\PageShowGameFoBLock.xaml"
            this.CMBProdactions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CMBProdactions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListGame = ((System.Windows.Controls.ListView)(target));
            
            #line 32 "..\..\..\PageApp\PageShowGameFoBLock.xaml"
            this.ListGame.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

