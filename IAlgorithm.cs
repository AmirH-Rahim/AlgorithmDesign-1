namespace AlgorithmDesign_1;

public interface IAlgorithm
{
    string Name { get; }

    string TimeComplexity { get; }

    string SpaceComplexity { get; }

    int[] Execute(int[] input);
}