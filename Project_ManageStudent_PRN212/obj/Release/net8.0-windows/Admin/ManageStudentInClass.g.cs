﻿#pragma checksum "..\..\..\..\Admin\ManageStudentInClass.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9BEA53A58B6E648E039FF85649D6A036E1F8FB5E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_ManageStudent_PRN212.Admin;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Project_ManageStudent_PRN212.Admin {
    
    
    /// <summary>
    /// ManageStudentInClass
    /// </summary>
    public partial class ManageStudentInClass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 97 "..\..\..\..\Admin\ManageStudentInClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvStudentInClass;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Admin\ManageStudentInClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStudentClass;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Admin\ManageStudentInClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbClassId;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\Admin\ManageStudentInClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbStudentId;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Admin\ManageStudentInClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project_ManageStudent_PRN212;component/admin/managestudentinclass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\ManageStudentInClass.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Admin\ManageStudentInClass.xaml"
            ((Project_ManageStudent_PRN212.Admin.ManageStudentInClass)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Load);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 85 "..\..\..\..\Admin\ManageStudentInClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnBackClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LvStudentInClass = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.txtStudentClass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cbbClassId = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbbStudentId = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 133 "..\..\..\..\Admin\ManageStudentInClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInsertClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 134 "..\..\..\..\Admin\ManageStudentInClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdateClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 135 "..\..\..\..\Admin\ManageStudentInClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 138 "..\..\..\..\Admin\ManageStudentInClass.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchStuent);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

