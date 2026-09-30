namespace AlgorithmComparator.Models;

public class FunctionalTestResult
{
    public int TotalTests { get; set; }

    public int PassedTests { get; set; }

    public bool AreEquivalent { get; set; }

    public int[]? FailedInput { get; set; }

    public int[]? OutputA { get; set; }

    public int[]? OutputB { get; set; }
}