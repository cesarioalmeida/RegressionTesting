using System;
using System.Collections.ObjectModel;

using DevExpress.Mvvm.DataAnnotations;
using RegressionTesting.Enums;

namespace RegressionTesting.Models
{
    [POCOViewModel]
    public class RegressionTest
    {
        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string CortexVersion { get; set; }

        public virtual string Notes { get; set; }

        public virtual RegressionTestStateEnum State { get; set; }

        public virtual DateTime StartTime { get; set; }

        public virtual DateTime EndTime { get; set; }

        public virtual TimeSpan RunTime => this.EndTime - this.StartTime;

        public virtual ObservableCollection<UnitTest> UnitTests { get; set; }

        public virtual int UnitTestsCount => this.UnitTests.Count;
    }
}