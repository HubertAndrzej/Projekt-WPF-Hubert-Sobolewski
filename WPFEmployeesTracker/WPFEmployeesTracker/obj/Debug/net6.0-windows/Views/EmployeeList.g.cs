﻿#pragma checksum "..\..\..\..\Views\EmployeeList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3A386D89422F746828DAA5F82CE3ED1F65520AAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPFEmployeesTracker.Views;


namespace WPFEmployeesTracker.Views {
    
    
    /// <summary>
    /// EmployeeList
    /// </summary>
    public partial class EmployeeList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridEmployee;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeNo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSurname;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDepartment;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPosition;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\EmployeeList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFEmployeesTracker;component/views/employeelist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\EmployeeList.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\Views\EmployeeList.xaml"
            ((WPFEmployeesTracker.Views.EmployeeList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridEmployee = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.txtEmployeeNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cmbDepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\..\..\Views\EmployeeList.xaml"
            this.cmbDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbDepartment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbPosition = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Views\EmployeeList.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Views\EmployeeList.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Views\EmployeeList.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\Views\EmployeeList.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\Views\EmployeeList.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

