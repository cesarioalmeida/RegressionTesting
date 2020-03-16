namespace RegressionTesting.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;

    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;

    using RegressionTesting.DataSources;
    using RegressionTesting.Enums;
    using RegressionTesting.Models;

    [POCOViewModel]
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.CurrentView = MainNavigationEnum.Overview;

            var regressionTestsFactory = new RegressionTestsFactory();

            this.RegressionTests = new ObservableCollection<RegressionTest>(regressionTestsFactory.GetRegressionTests().OrderByDescending(x => x.StartTime));

            this.LatestRegressionTest = RegressionTests.OrderByDescending(x => x.StartTime).First();

            this.RecentErrors = new ObservableCollection<RegressionError>(RegressionTests.SelectMany(x => x.UnitTests).Select(y => y.Error).Where(_ => _ != null));
        }

        public virtual INavigationService NavigationService => this.GetService<INavigationService>();

        public virtual MainNavigationEnum CurrentView { get; set; }

        public virtual ObservableCollection<RegressionTest> RegressionTests { get; set; }

        public virtual RegressionTest LatestRegressionTest { get; set; }

        public virtual RegressionTest SelectedRegressionTest { get; set; }

        public virtual ObservableCollection<RegressionError> RecentErrors { get; set; }


        [Command]
        public virtual void ShowOverview()
        {
            this.NavigationService.Navigate("Overview", null, this);
            this.CurrentView = MainNavigationEnum.Overview;
        }

        [Command]
        public virtual void ShowLatestRegressionTest()
        {
            this.NavigationService.Navigate("LatestRegressionTest", null, this);
            this.CurrentView = MainNavigationEnum.LatestTest;
        }

        [Command]
        public virtual void ShowNewTest()
        {
            this.NavigationService.Navigate("NewTest", null, this);
            this.CurrentView = MainNavigationEnum.New;
        }
    }
}