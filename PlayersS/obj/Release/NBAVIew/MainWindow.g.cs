﻿#pragma checksum "..\..\..\NBAVIew\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4652EBEEC11DDAF3E1080AF84E03D97B743BFAFB65EF6162CBE6268FDAA0D4EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using PlayersS;
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


namespace PlayersS {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Tabela;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WprowadzanieImienia;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SzukajZ;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WprowadzenieKraju;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SzukajK;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PodajIlosc;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IloscZawodnikow;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\NBAVIew\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/PlayersS;component/nbaview/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NBAVIew\MainWindow.xaml"
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
            
            #line 27 "..\..\..\NBAVIew\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\..\NBAVIew\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Wczytaj_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Tabela = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.WprowadzanieImienia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SzukajZ = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\NBAVIew\MainWindow.xaml"
            this.SzukajZ.Click += new System.Windows.RoutedEventHandler(this.SzukajZ_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WprowadzenieKraju = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SzukajK = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\NBAVIew\MainWindow.xaml"
            this.SzukajK.Click += new System.Windows.RoutedEventHandler(this.SzukajK_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PodajIlosc = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\NBAVIew\MainWindow.xaml"
            this.PodajIlosc.Click += new System.Windows.RoutedEventHandler(this.PodajIlosc_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.IloscZawodnikow = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\NBAVIew\MainWindow.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
