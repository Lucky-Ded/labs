﻿#pragma checksum "..\..\Notebook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62392246500FEEE2D921595DD4B214BF83ECEEA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NormalWpfApp;
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


namespace NormalWpfApp {
    
    
    /// <summary>
    /// Notebook
    /// </summary>
    public partial class Notebook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\Notebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox notebox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Notebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Notebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nbt;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Notebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBnb;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Notebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nbtl;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Notebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ruscknb;
        
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
            System.Uri resourceLocater = new System.Uri("/NormalWpfApp;component/notebook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Notebook.xaml"
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
            this.notebox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.addbox = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Notebook.xaml"
            this.addbox.Click += new System.Windows.RoutedEventHandler(this.Addbox_Click);
            
            #line default
            #line hidden
            
            #line 41 "..\..\Notebook.xaml"
            this.addbox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Addbox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 41 "..\..\Notebook.xaml"
            this.addbox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Addbox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nbt = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\Notebook.xaml"
            this.nbt.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Nbt_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackBnb = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Notebook.xaml"
            this.BackBnb.Click += new System.Windows.RoutedEventHandler(this.BackBnb_Click);
            
            #line default
            #line hidden
            
            #line 50 "..\..\Notebook.xaml"
            this.BackBnb.MouseEnter += new System.Windows.Input.MouseEventHandler(this.BackBnb_MouseEnter);
            
            #line default
            #line hidden
            
            #line 50 "..\..\Notebook.xaml"
            this.BackBnb.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackBnb_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.nbtl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ruscknb = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\Notebook.xaml"
            this.ruscknb.Checked += new System.Windows.RoutedEventHandler(this.Ruscknb_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

