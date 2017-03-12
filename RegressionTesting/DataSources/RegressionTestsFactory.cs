
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using RegressionTesting.Enums;
using RegressionTesting.Models;

namespace RegressionTesting.DataSources
{
    public class RegressionTestsFactory
    {
        private static readonly Random RandomNumberGenerator = new Random();

        public List<RegressionTest> GetRegressionTests()
        {
            var regressionTests = Enumerable.Range(0, 10)
                .Select(i => new RegressionTest
                {
                    Id = Guid.NewGuid(),
                    Name = "Test " + i + 1,
                    CortexVersion = "Cortex201511" + RandomNumberGenerator.Next(10, 16),
                    UnitTests = new ObservableCollection<UnitTest>()
                }).ToList();

            foreach (var regressionTest in regressionTests)
            {
                var unitTests = Enumerable.Range(0, RandomNumberGenerator.Next(3, 7)).Select(i => new UnitTest()
                {
                    Parent = regressionTest,
                    Name = "Restatement Data Test " + i + 1,
                    State = RandomEnumValue<RegressionTestStateEnum>(),
                    StartTime = DateTime.Now.AddMinutes(RandomNumberGenerator.Next(-500, -200)),
                    EndTime = DateTime.Now.AddMinutes(RandomNumberGenerator.Next(-120, 0))
                }).ToList();

                var failedTests = unitTests.Where(x => x.State == RegressionTestStateEnum.Failed).ToList();

                if (failedTests.Any())
                {
                    failedTests.ForEach(x => x.Error = new RegressionError
                    {
                        Parent = x,
                        Error = "Exception: something happened here; " + RandomNumberGenerator.NextDouble(),
                        TimeStamp = x.EndTime
                    });

                }

                regressionTest.UnitTests = new ObservableCollection<UnitTest>(unitTests);

                regressionTest.StartTime = regressionTest.UnitTests.OrderBy(x => x.StartTime).First().StartTime;
                regressionTest.EndTime = regressionTest.UnitTests.OrderByDescending(x => x.EndTime).First().StartTime;
                regressionTest.State = regressionTest.UnitTests.Any(x => x.State == RegressionTestStateEnum.Cancelled)
                    ? RegressionTestStateEnum.Cancelled
                    : regressionTest.UnitTests.Any(x => x.State == RegressionTestStateEnum.Failed)
                        ? RegressionTestStateEnum.Failed
                        : regressionTest.UnitTests.Any(x => x.State == RegressionTestStateEnum.Running)
                            ? RegressionTestStateEnum.Running
                            : regressionTest.UnitTests.All(x => x.State == RegressionTestStateEnum.Pending)
                                ? RegressionTestStateEnum.Pending
                                : regressionTest.UnitTests.All(x => x.State == RegressionTestStateEnum.Succeeded)
                                    ? RegressionTestStateEnum.Running
                                    : RegressionTestStateEnum.None;
            }

            return regressionTests.ToList();
        }

        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(RandomNumberGenerator.Next(v.Length));
        }

    }
}