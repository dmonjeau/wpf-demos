#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Chart;
using Syncfusion.Windows.Shared;
using System.Diagnostics;
using System.Collections;
using System.Collections.ObjectModel;


namespace SurfaceChart
{

    public partial class Window1 : Window
    {
        #region Initialization
        /// <summary>
        /// Contrcutor for window1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        public Window1()
        {
            InitializeComponent();
        }

        #endregion
    }

    public class Data
    {
        public double XValue { get; set; }

        public double YValue { get; set; }

    }

    public class DataCollection
    {
        public DataCollection()
        {
            this.Collection1 = new List<Data>();
            this.Collection2 = new List<Data>();
            this.Collection3 = new List<Data>();
            this.Collection4 = new List<Data>();
            this.Collection5 = new List<Data>();
            this.Collection6 = new List<Data>();
            Random rand = new Random();
            for (int i = 1; i < 10; i++)
            {
                this.Collection1.Add(new Data() { XValue = i, YValue = rand.Next(10,20) });
                this.Collection2.Add(new Data() { XValue = i, YValue = rand.Next(10,80) });
                this.Collection3.Add(new Data() { XValue = i, YValue = rand.Next(20, 100) });
                this.Collection4.Add(new Data() { XValue = i, YValue = rand.Next(10,90) });
                this.Collection5.Add(new Data() { XValue = i, YValue = rand.Next(20, 60) });
                this.Collection6.Add(new Data() { XValue = i, YValue = rand.Next(30,90) });
            }
        }

        public List<Data> Collection1
        {
            get;
            set;
        }

        public List<Data> Collection2
        {
            get;
            set;
        }
        public List<Data> Collection3
        {
            get;
            set;
        }
        public List<Data> Collection4
        {
            get;
            set;
        }
        public List<Data> Collection5
        {
            get;
            set;
        }
        public List<Data> Collection6
        {
            get;
            set;
        }
    }
}

