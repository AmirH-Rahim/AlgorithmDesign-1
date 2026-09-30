namespace AlgorithmComparator.Services;

public class TestGenerator
{
    private readonly Random _random = new(42);

    public List<int[]> Generate(
        int randomTestCount,
        int minSize,
        int maxSize,
        int minValue,
        int maxValue)
    {
        var tests = new List<int[]>();

        AddEdgeCases(tests);

        for (int i = 0; i < randomTestCount; i++)
        {
            int size = _random.Next(minSize, maxSize + 1);

            var array = new int[size];

            for (int j = 0; j < size; j++)
            {
                array[j] = _random.Next(minValue, maxValue + 1);
            }

            tests.Add(array);
        }

        return tests;
    }

    private void AddEdgeCases(List<int[]> tests)
    {
        tests.Add([]);
        tests.Add([1]);
        tests.Add([1, 2, 3, 4, 5]);
        tests.Add([5, 4, 3, 2, 1]);
        tests.Add([1, 1, 1, 1, 1]);
        tests.Add([0, 0, 0]);
        tests.Add([-1, -2, -3, -4]);
        tests.Add([-5, 10, 0, -2, 8]);
        tests.Add([int.MinValue, 0, int.MaxValue]);
        tests.Add([10, -10, 10, -10, 0]);
    }
}