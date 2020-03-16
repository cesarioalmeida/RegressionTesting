namespace RegressionTesting.DataSources
{
    using System.Collections.ObjectModel;

    using RegressionTesting.ViewModels;

    public class DataSource
    {
        public DataSource()
        {
            this.Data = this.CreateDataSource();
        }

        public ObservableCollection<TestDataViewModel> Data { get; }

        protected ObservableCollection<TestDataViewModel> CreateDataSource()
        {
            var res = new ObservableCollection<TestDataViewModel>
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
    }
}