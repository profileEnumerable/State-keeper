﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0F2AC24FFE9C2F7F21DA6E87A46E8C1FA3D532E76928524AF934BF3AACAB258"
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
using Text_style_setter;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Text_style_setter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MainText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label backColorLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label foreColorLabel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fontSizeLabel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fontStyleLabel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ClrPcker_BackColor;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ClrPcker_ForeColor;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontSizeChoise;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontFamilyChoise;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveSettings;
        
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
            System.Uri resourceLocater = new System.Uri("/Text style setter;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 9 "..\..\MainWindow.xaml"
            ((Text_style_setter.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.backColorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.foreColorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.fontSizeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.fontStyleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.ClrPcker_BackColor = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.ClrPcker_BackColor.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.ClrPcker_BackColor_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClrPcker_ForeColor = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.ClrPcker_ForeColor.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.ClrPcker_ForeColor_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FontSizeChoise = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.FontSizeChoise.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSizeChoise_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FontFamilyChoise = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.FontFamilyChoise.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontFamilyChoise_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SaveSettings = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.SaveSettings.Click += new System.Windows.RoutedEventHandler(this.SaveSettings_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

