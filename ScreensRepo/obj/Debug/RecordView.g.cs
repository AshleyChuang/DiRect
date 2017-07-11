﻿#pragma checksum "..\..\RecordView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "24CA5DAB1789D5B28A987F7D20893970"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using GMap.NET.WindowsPresentation;
using Microsoft.Maps.MapControl.WPF;
using ScreensInterfaces;
using ScreensRepo;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Controls.DataVisualization.Charting.Primitives;
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


namespace ScreensRepo {
    
    
    /// <summary>
    /// RecordView
    /// </summary>
    public partial class RecordView : ScreensInterfaces.MenuViewBase, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 81 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map mapView;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ScrollArea;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart chart1;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.LinearAxis myLinearAxis;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.DateTimeAxis myDateTimeAxis;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.AreaSeries myLineSeries;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Latitude;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LatitudeTextBox;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Longitude;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LongitudeTextBox;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WaterLevelTextBlock;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WaterLevelTextBox;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\RecordView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/ScreensRepo;component/recordview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RecordView.xaml"
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
            case 2:
            this.mapView = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            case 3:
            this.ScrollArea = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 4:
            this.chart1 = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            
            #line 92 "..\..\RecordView.xaml"
            this.chart1.MouseMove += new System.Windows.Input.MouseEventHandler(this.chart1_MouseMove);
            
            #line default
            #line hidden
            
            #line 93 "..\..\RecordView.xaml"
            this.chart1.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.chart1_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.myLinearAxis = ((System.Windows.Controls.DataVisualization.Charting.LinearAxis)(target));
            return;
            case 6:
            this.myDateTimeAxis = ((System.Windows.Controls.DataVisualization.Charting.DateTimeAxis)(target));
            return;
            case 7:
            this.myLineSeries = ((System.Windows.Controls.DataVisualization.Charting.AreaSeries)(target));
            return;
            case 8:
            this.TimeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TimeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Latitude = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.LatitudeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Longitude = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.LongitudeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.WaterLevelTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.WaterLevelTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.DescriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this.Save_Button = ((System.Windows.Controls.Button)(target));
            
            #line 167 "..\..\RecordView.xaml"
            this.Save_Button.Click += new System.Windows.RoutedEventHandler(this.Click_On_Save_Button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 1:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeftButtonDownEvent;
            
            #line 35 "..\..\RecordView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.LineSeriesDataPoint_MouseLeftButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

