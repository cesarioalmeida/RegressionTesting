namespace RegressionTesting
{
    using RegressionTesting.DataSources;

    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = new DataSource();
        }
    }
}
