# Algorithm Comparator

A simple C# console application for comparing two algorithms from three main perspectives:

1. Functional equivalence
2. Time complexity and execution time
3. Space complexity and memory allocation

---

## Project Goal

The purpose of this project is to provide a simple platform for comparing two algorithms and answering the following questions:

- Do both algorithms produce the same result for the same input?
- Which algorithm executes faster?
- Which algorithm uses less memory?
- What are their theoretical time complexities?
- What are their theoretical space complexities?

This project is implemented as a console application using C# and .NET.

---

## Supported Algorithms

Currently, the application contains the following sorting algorithms:

- Bubble Sort
- Insertion Sort
- Selection Sort
- Merge Sort

All algorithms implement a common interface so new algorithms can easily be added.

---

## Project Structure

```text
AlgorithmComparator
│
├── Algorithms
│   ├── IAlgorithm.cs
│   ├── BubbleSort.cs
│   ├── InsertionSort.cs
│   ├── SelectionSort.cs
│   └── MergeSort.cs
│
├── Models
│   ├── FunctionalTestResult.cs
│   └── PerformanceResult.cs
│
├── Services
│   ├── TestGenerator.cs
│   ├── AlgorithmTester.cs
│   └── PerformanceAnalyzer.cs
│
└── Program.cs
