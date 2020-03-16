namespace RegressionTesting.Models
{
    using System;

    using DevExpress.Mvvm.DataAnnotations;

    [POCOViewModel]
    public class RegressionError
    {
        public virtual UnitTest Parent { get; set; }

        public virtual string Error { get; set; }

        public virtual DateTime TimeStamp { get; set; }
    }
}