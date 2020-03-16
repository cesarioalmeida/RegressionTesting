namespace RegressionTesting.Models
{
    using System;

    using DevExpress.Mvvm.DataAnnotations;

    using RegressionTesting.Enums;

    [POCOViewModel]
    public class UnitTest
    {
        public virtual RegressionTest Parent { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime StartTime { get; set; }

        public virtual DateTime EndTime { get; set; }

        public virtual TimeSpan RunTime => this.EndTime - this.StartTime;

        public virtual RegressionTestStateEnum State { get; set; }

        public virtual RegressionError Error { get; set; }
    }
}