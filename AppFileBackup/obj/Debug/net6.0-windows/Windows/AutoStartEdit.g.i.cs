﻿#pragma checksum "..\..\..\..\Windows\AutoStartEdit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2A866562FF95AAB16AD0E57116C97E4529C17B62"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// AutoStartEdit
    /// </summary>
    public partial class AutoStartEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridEditAutoStart;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCurrentDate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCurrentDate;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerNew;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSave;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelDescription;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDescription;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\AutoStartEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxIsActive;
        
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
            System.Uri resourceLocater = new System.Uri("/AppFileBackup;component/windows/autostartedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AutoStartEdit.xaml"
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
            
            #line 8 "..\..\..\..\Windows\AutoStartEdit.xaml"
            ((AppFileBackup.Windows.AutoStartEdit)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridEditAutoStart = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.TextBoxCurrentDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LabelCurrentDate = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.DatePickerNew = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.ButtonSave = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Windows\AutoStartEdit.xaml"
            this.ButtonSave.Click += new System.Windows.RoutedEventHandler(this.ButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Windows\AutoStartEdit.xaml"
            this.ButtonCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonCancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LabelDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.TextBoxDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.CheckBoxIsActive = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

