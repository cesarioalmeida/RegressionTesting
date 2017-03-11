using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Layout.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.DataAnnotations;


namespace RegressionTesting
{
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataSource();
        }

    }

    public class TestData
    {
        public string Filename { get; set; }
        public string State { get; set; }
        public int Progress { get; set; }
    }

    [POCOViewModel]
    public class TestDataViewModel
    {
        readonly TestData data;
        public TestDataViewModel()
        {
            data = new TestData();
        }

        public virtual string Filename { get; set; }

        public virtual string State { get; set; }

        public virtual int Progress { get; set; }

    }

    public class DataSource
    {
        ObservableCollection<TestDataViewModel> source;
        public DataSource()
        {
            source = CreateDataSource();
        }
        protected ObservableCollection<TestDataViewModel> CreateDataSource()
        {
            ObservableCollection<TestDataViewModel> res = new ObservableCollection<TestDataViewModel>();
            res.Add(new TestDataViewModel() { Filename = "Row0", State="Download in progress", Progress = 12 });
            res.Add(new TestDataViewModel() { Filename = "Row1", State="Download in progress", Progress = 54 });
            res.Add(new TestDataViewModel() { Filename = "Row2", State="Download in progress", Progress = 0 });
            res.Add(new TestDataViewModel() { Filename = "Row3", State="Download in progress", Progress = 100 });
            res.Add(new TestDataViewModel() { Filename = "Row4", State="Download in progress", Progress = 87 });
            res.Add(new TestDataViewModel() { Filename = "Row5", State="Download in progress", Progress = 89 });
            res.Add(new TestDataViewModel() { Filename = "Row6", State="Download in progress", Progress = 100 });
            res.Add(new TestDataViewModel() { Filename = "Row7", State="Download in progress", Progress = 34 });
            res.Add(new TestDataViewModel() { Filename = "Row8", State="Download in progress", Progress = 21 });
            res.Add(new TestDataViewModel() { Filename = "Row9", State="Download in progress", Progress = 9 });
            return res;
        }
        public ObservableCollection<TestDataViewModel> Data { get { return source; } }
    }
}
