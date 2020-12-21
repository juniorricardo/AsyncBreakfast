using NUnit.Framework;
using Solution.Kata;
using System.Collections.Generic;

namespace Solution.Tests
{
    public class HighestScoringWordTest
    {
        [TestFixture]
        public class Sample_Tests
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
                    yield return new TestCaseData("the the the").Returns("the");
                    yield return new TestCaseData("aa b").Returns("aa");
                    yield return new TestCaseData("b aa").Returns("b");
                    yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
                    yield return new TestCaseData("take me to semynak").Returns("semynak");
                }
            }

            [Test, TestCaseSource("testCases")]
            public string Test(string s) => HighestScoringWordKata.High(s);
            [Test, TestCaseSource("testCases")]
            public string Test2(string s) => HighestScoringWordKata.High2(s);
            [Test, TestCaseSource("testCases")]
            public string Test3(string s) => HighestScoringWordKata.High3(s);
        }
    }
}