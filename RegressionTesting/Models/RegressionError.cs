using System;
using DevExpress.Mvvm.DataAnnotations;

namespace RegressionTesting.Models
{
    [POCOViewModel]
    public class RegressionError
    {
        public virtual UnitTest Parent { get; set; }

        public virtual string Error { get; set; }

        public virtual DateTime TimeStamp { get; set; }
    }
}