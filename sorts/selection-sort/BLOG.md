# Blog Notes: Selection Sort
Selection sort is a simple sorting algorithm. This sorting algorithm is an in-place comparison-based algorithm in which the list is divided into two parts, the sorted part at the left end and the unsorted part at the right end. Initially, the sorted part is empty and the unsorted part is the entire list.

The smallest element is selected from the unsorted array and swapped with the leftmost element, and that element becomes a part of the sorted array. This process continues moving unsorted array boundary by one element to the right.

This algorithm is not suitable for large data sets as its average and worst case complexities are of Ο(n2), where n is the number of items.

### Algorithm
Step 1 − Set MIN to location 0
Step 2 − Search the minimum element in the list
Step 3 − Swap with value at location MIN
Step 4 − Increment MIN to point to next element
Step 5 − Repeat until list is sorted

#### Properties
* Stable
* O(1) extra space
* O(n2) comparisons and swaps
* Adaptive: O(n) time when nearly sorted
* Worst case: reversed sort

### Pseudocode
`InsertionSort(int[] arr)
  
  FOR i = 1 to arr.length
    int j <-- i - 1
    int temp <-- arr[i]
  
  WHILE j >= 0 AND temp < arr[j]
    arr[j + 1] <-- arr[j]
    j <-- j - 1
    arr[j + 1] <-- temp`
    
### Watch
- [Video](https://www.youtube.com/watch?v=g-PGLbMth_g)

### Read

- [Article 1](https://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm)
