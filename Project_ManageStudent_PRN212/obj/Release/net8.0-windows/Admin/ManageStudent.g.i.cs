﻿#pragma checksum "..\..\..\..\Admin\ManageStudent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "688A4379ED274FCB3AF00589AF59073DFBCCC8E0"
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
    /// ManageStudent
    /// </summary>
    public partial class ManageStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\..\..\Admin\ManageStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvStudentInClass;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Admin\ManageStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStudentClass;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Admin\ManageStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbClassId;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Admin\ManageStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbStudentId;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Admin\ManageStudent.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Project_ManageStudent_PRN212;component/admin/managestudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\ManageStudent.xaml"
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
            
            #line 9 "..\..\..\..\Admin\ManageStudent.xaml"
            ((Project_ManageStudent_PRN212.Admin.ManageStudent)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Load);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 71 "..\..\..\..\Admin\ManageStudent.xaml"
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
            
            #line 119 "..\..\..\..\Admin\ManageStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInsertClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 120 "..\..\..\..\Admin\ManageStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdateClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 121 "..\..\..\..\Admin\ManageStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 124 "..\..\..\..\Admin\ManageStudent.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchStuent);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

