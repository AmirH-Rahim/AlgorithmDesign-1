namespace AlgorithmDesign_1;

public class InsertionSort : IAlgorithm
{
    public string Name => "Insertion Sort";

    public string TimeComplexity => "O(n²)";

    public string SpaceComplexity => "O(1)";

    public int[] Execute(int[] input)
    {
        var array = (int[])input.Clone();

        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }

        return array;
    }
}