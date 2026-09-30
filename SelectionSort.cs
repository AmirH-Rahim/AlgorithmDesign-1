namespace AlgorithmDesign_1;

public class SelectionSort : IAlgorithm
{
    public string Name => "Selection Sort";

    public string TimeComplexity => "O(n²)";

    public string SpaceComplexity => "O(1)";

    public int[] Execute(int[] input)
    {
        var array = (int[])input.Clone();

        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            (array[i], array[minIndex]) =
                (array[minIndex], array[i]);
        }

        return array;
    }
}