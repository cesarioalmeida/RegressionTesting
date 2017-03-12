using System.Collections.ObjectModel;
using DevExpress.Mvvm.DataAnnotations;


namespace RegressionTesting
{
    public partial class MainWindow
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
        public virtual string Filename { get; set; }

        public virtual string State { get; set; }

        public virtual int Progress { get; set; }

    }

    public class DataSource
    {
        public DataSource()
        {
            this.Data = CreateDataSource();
        }
        protected ObservableCollection<TestDataViewModel> CreateDataSource()
        {
            ObservableCollection<TestDataViewModel> res = new ObservableCollection<TestDataViewModel>
                                                              {
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row0",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  12
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row1",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  54
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row2",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  0
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row3",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  100
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row4",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  87
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row5",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  89
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row6",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  100
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row7",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  34
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row8",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  21
                                                                          },
                                                                  new TestDataViewModel
                                                                          {
                                                                              Filename
                                                                                  =
                                                                                  "Row9",
                                                                              State
                                                                                  =
                                                                                  "Download in progress",
                                                                              Progress
                                                                                  =
                                                                                  9
                                                                          }
                                                              };
            return res;
        }
        public ObservableCollection<TestDataViewModel> Data { get; }
    }
}
