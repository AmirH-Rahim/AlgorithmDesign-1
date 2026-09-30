namespace AlgorithmDesign_1;

public class BubbleSort : IAlgorithm
{
    public string Name => "Bubble Sort";

    public string TimeComplexity => "O(n²)";

    public string SpaceComplexity => "O(1)";

    public int[] Execute(int[] input)
    {
        var array = (int[])input.Clone();

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    (array[j], array[j + 1]) =
                        (array[j + 1], array[j]);
                }
            }
        }

        return array;
    }
}