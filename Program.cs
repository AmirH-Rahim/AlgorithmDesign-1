using AlgorithmComparator.Algorithms;
using AlgorithmComparator.Services;
using AlgorithmDesign_1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var algorithms = new List<IAlgorithm>
{
    new BubbleSort(),
    new InsertionSort(),
    new SelectionSort(),
    new MergeSort()
};

Console.WriteLine("=================================");
Console.WriteLine("      Algorithm Comparator");
Console.WriteLine("=================================");
Console.WriteLine();

var firstAlgorithm = SelectAlgorithm(
    algorithms,
    "Select first algorithm:"
);

Console.WriteLine();

var secondAlgorithm = SelectAlgorithm(
    algorithms,
    "Select second algorithm:"
);

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("Selected Algorithms");
Console.WriteLine("=================================");

Console.WriteLine();
Console.WriteLine($"Algorithm A: {firstAlgorithm.Name}");
Console.WriteLine($"Time Complexity: {firstAlgorithm.TimeComplexity}");
Console.WriteLine($"Space Complexity: {firstAlgorithm.SpaceComplexity}");

Console.WriteLine();

Console.WriteLine($"Algorithm B: {secondAlgorithm.Name}");
Console.WriteLine($"Time Complexity: {secondAlgorithm.TimeComplexity}");
Console.WriteLine($"Space Complexity: {secondAlgorithm.SpaceComplexity}");

var testGenerator = new TestGenerator();

var testCases = testGenerator.Generate(
    randomTestCount: 100,
    minSize: 1,
    maxSize: 100,
    minValue: -1000,
    maxValue: 1000
);

var algorithmTester = new AlgorithmTester();

var testResult = algorithmTester.Compare(
    firstAlgorithm,
    secondAlgorithm,
    testCases
);

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("Functional Test");
Console.WriteLine("=================================");
Console.WriteLine();

if (testResult.AreEquivalent)
{
    Console.WriteLine("No differences were found.");
    Console.WriteLine(
        $"Passed: {testResult.PassedTests} / {testResult.TotalTests}"
    );
}
else
{
    Console.WriteLine("The algorithms produced different outputs.");
    Console.WriteLine();

    Console.WriteLine(
        $"Passed before failure: {testResult.PassedTests}"
    );

    Console.WriteLine();

    Console.WriteLine(
        $"Input: [{string.Join(", ", testResult.FailedInput!)}]"
    );

    Console.WriteLine();

    Console.WriteLine(
        $"{firstAlgorithm.Name}: [{string.Join(", ", testResult.OutputA!)}]"
    );

    Console.WriteLine(
        $"{secondAlgorithm.Name}: [{string.Join(", ", testResult.OutputB!)}]"
    );
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

static IAlgorithm SelectAlgorithm(
    List<IAlgorithm> algorithms,
    string message)
{
    while (true)
    {
        Console.WriteLine(message);

        for (int i = 0; i < algorithms.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {algorithms[i].Name}");
        }

        Console.Write("Choice: ");

        string? input = Console.ReadLine();

        if (int.TryParse(input, out int choice) &&
            choice >= 1 &&
            choice <= algorithms.Count)
        {
            return algorithms[choice - 1];
        }

        Console.WriteLine();
        Console.WriteLine("Invalid choice.");
        Console.WriteLine();
    }
}