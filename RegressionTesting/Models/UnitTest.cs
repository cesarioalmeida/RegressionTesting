using System;
using DevExpress.Mvvm.DataAnnotations;
using RegressionTesting.Enums;

namespace RegressionTesting.Models
{
    [POCOViewModel]
    public class UnitTest
    {
        public virtual RegressionTest Parent { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime StartTime { get; set; }

        public virtual DateTime EndTime { get; set; }

        public virtual TimeSpan RunTime { get { return EndTime - StartTime; } }

        public virtual RegressionTestStateEnum State { get; set; }

        public virtual RegressionError Error { get; set; }
    }
}