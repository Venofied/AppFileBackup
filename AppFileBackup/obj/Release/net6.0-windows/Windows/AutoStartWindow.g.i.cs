﻿#pragma checksum "..\..\..\..\Windows\AutoStartWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5EECDC7AF914A381AEBD4C9CDD8707E12C50667E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AppFileBackup.Models;
using AppFileBackup.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace AppFileBackup.Windows {
    
    
    /// <summary>
    /// AutoStartWindow
    /// </summary>
    public partial class AutoStartWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AutoStartSettingsGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddNewAutoStartGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DataPickerAutoStart;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewDate;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEdit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRefresh;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AutoStartDataGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridDescription;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelDescription;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\AutoStartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDescription;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppFileBackup;component/windows/autostartwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AutoStartWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AutoStartSettingsGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.AddNewAutoStartGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.DataPickerAutoStart = ((System.Windows.Controls.DatePicker)(target));
            
            #line 26 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.DataPickerAutoStart.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DataPickerAutoStart_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddNewDate = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.AddNewDate.Click += new System.Windows.RoutedEventHandler(this.AddNewDate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Close = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.ButtonEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.ButtonRefresh.Click += new System.Windows.RoutedEventHandler(this.ButtonRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AutoStartDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 37 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.AutoStartDataGrid.Loaded += new System.Windows.RoutedEventHandler(this.AutoStartDataGrid_Loaded);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\Windows\AutoStartWindow.xaml"
            this.AutoStartDataGrid.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.AutoStartDataGrid_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GridDescription = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.LabelDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.TextBoxDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
