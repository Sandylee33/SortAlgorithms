using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : Sort {

    int partition(int[] array, int startIndex, int endIndex)
    {
        int pivot = startIndex;

        for (int i = startIndex; i < endIndex; i++)
        {
            if (array[i]<=array[endIndex])
            {
                swap(array,i,pivot);
                pivot++;
            }
        }

        swap(array,pivot,endIndex);
        return pivot;
    }

    void swap(int[] array, int firstIndex, int secondIndex)
    {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }


	public override void sort(int[] array, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int pivot = partition(array, startIndex,endIndex);
            sort(array, startIndex, pivot - 1);
            sort(array, pivot + 1, endIndex);
        }

    }


	
}
