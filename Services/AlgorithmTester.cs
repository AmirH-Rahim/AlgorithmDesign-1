using AlgorithmComparator.Algorithms;
using AlgorithmComparator.Models;
using AlgorithmDesign_1;

namespace AlgorithmComparator.Services;

public class AlgorithmTester
{
    public FunctionalTestResult Compare(
        IAlgorithm algorithmA,
        IAlgorithm algorithmB,
        List<int[]> testCases)
    {
        int passedTests = 0;

        foreach (var testCase in testCases)
        {
            var inputA = (int[])testCase.Clone();
            var inputB = (int[])testCase.Clone();

            var outputA = algorithmA.Execute(inputA);
            var outputB = algorithmB.Execute(inputB);

            if (!outputA.SequenceEqual(outputB))
            {
                return new FunctionalTestResult
                {
                    TotalTests = testCases.Count,
                    PassedTests = passedTests,
                    AreEquivalent = false,
                    FailedInput = testCase,
                    OutputA = outputA,
                    OutputB = outputB
                };
            }

            passedTests++;
        }

        return new FunctionalTestResult
        {
            TotalTests = testCases.Count,
            PassedTests = passedTests,
            AreEquivalent = true
        };
    }
}