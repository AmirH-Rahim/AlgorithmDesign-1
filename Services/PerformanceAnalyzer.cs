using System.Diagnostics;
using AlgorithmDesign_1.Services;
using AlgorithmDesign_1;

namespace AlgorithmComparator.Services;

public class PerformanceAnalyzer
{
    public PerformanceResult Measure(
        IAlgorithm algorithm,
        int[] input,
        int iterations = 10)
    {
        for (int i = 0; i < 3; i++)
        {
            algorithm.Execute(input);
        }

        double totalMilliseconds = 0;
        long totalAllocatedBytes = 0;

        for (int i = 0; i < iterations; i++)
        {
            long memoryBefore = GC.GetAllocatedBytesForCurrentThread();

            var stopwatch = Stopwatch.StartNew();

            algorithm.Execute(input);

            stopwatch.Stop();

            long memoryAfter = GC.GetAllocatedBytesForCurrentThread();

            totalMilliseconds += stopwatch.Elapsed.TotalMilliseconds;
            totalAllocatedBytes += memoryAfter - memoryBefore;
        }

        return new PerformanceResult
        {
            AverageMilliseconds = totalMilliseconds / iterations,
            AverageAllocatedBytes = totalAllocatedBytes / iterations
        };
    }
}