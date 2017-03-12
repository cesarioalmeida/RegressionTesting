using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using RegressionTesting.DataSources;
using RegressionTesting.Models;

namespace RegressionTesting.ViewModels
{
    [POCOViewModel]
    public class MainViewModel : ViewModelBase
    {
        private static RegressionTestsFactory _regressionTestsFactory;

        public MainViewModel()
        {
            CurrentView = MainNavigationEnum.Overview;

            _regressionTestsFactory = new RegressionTestsFactory();

            RegressionTests = new ObservableCollection<RegressionTest>(_regressionTestsFactory.GetRegressionTests().OrderByDescending(x => x.StartTime));

            LatestRegressionTest = RegressionTests.OrderByDescending(x => x.StartTime).First();

            RecentErrors = new ObservableCollection<RegressionError>(RegressionTests.SelectMany(x => x.UnitTests).Select(y => y.Error).Where(_ => _ != null));
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
            NavigationService.Navigate("Overview", null, this);
            CurrentView = MainNavigationEnum.Overview;
        }

        [Command]
        public virtual void ShowLatestRegressionTest()
        {
            NavigationService.Navigate("LatestRegressionTest", null, this);
            CurrentView = MainNavigationEnum.LatestTest;
        }

        [Command]
        public virtual void ShowNewTest()
        {
            NavigationService.Navigate("NewTest", null, this);
            CurrentView = MainNavigationEnum.New;
        }
    }
}