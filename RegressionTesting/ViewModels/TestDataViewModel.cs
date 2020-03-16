namespace RegressionTesting.ViewModels
{
    using DevExpress.Mvvm.DataAnnotations;

    [POCOViewModel]
    public class TestDataViewModel
    {
        public virtual string Filename { get; set; }

        public virtual string State { get; set; }

        public virtual int Progress { get; set; }

    }
}