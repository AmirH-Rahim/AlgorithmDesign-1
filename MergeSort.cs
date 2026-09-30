using AlgorithmDesign_1;

namespace AlgorithmComparator.Algorithms;

public class MergeSort : IAlgorithm
{
    public string Name => "Merge Sort";

    public string TimeComplexity => "O(n log n)";

    public string SpaceComplexity => "O(n)";

    public int[] Execute(int[] input)
    {
        var array = (int[])input.Clone();

        Sort(array, 0, array.Length - 1);

        return array;
    }

    private void Sort(int[] array, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int middle = left + (right - left) / 2;

        Sort(array, left, middle);
        Sort(array, middle + 1, right);

        Merge(array, left, middle, right);
    }

    private void Merge(int[] array, int left, int middle, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left;
        int j = middle + 1;
        int k = 0;

        while (i <= middle && j <= right)
        {
            if (array[i] <= array[j])
            {
                temp[k++] = array[i++];
            }
            else
            {
                temp[k++] = array[j++];
            }
        }

        while (i <= middle)
        {
            temp[k++] = array[i++];
        }

        while (j <= right)
        {
            temp[k++] = array[j++];
        }

        for (int index = 0; index < temp.Length; index++)
        {
            array[left + index] = temp[index];
        }
    }
}