using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSort : Sort{

	public override void sort(int[] array, int startIndex, int endIndex)
	{
		if (startIndex < endIndex) 
		{
			int midIndex = (startIndex + endIndex) / 2;
			sort (array, startIndex, midIndex);
			sort (array, midIndex + 1, endIndex);
			merge (array, startIndex, midIndex, endIndex);
		}
	}

    void merge(int[] array, int startIndex, int midIndex, int endIndex)
	{
		int[] lowHalf = new int[midIndex - startIndex + 1];
		int[] highHalf = new int[endIndex - midIndex];

		//List<int> firstHalf = new List<int> ();
		//List<int> secondHalf = new List<int> ();

		int k = startIndex;
		int i, j;
		for (i = 0; k <= midIndex; i++,k++) {
			lowHalf[i] = array [k];
		}
		for (j = 0; k <= endIndex; j++,k++)
		{
			highHalf[j] = array [k];
		}

		//int[] lowHalf = firstHalf.ToArray ();
		//int[] highHalf = secondHalf.ToArray ();

		k = startIndex;
		i = 0;
		j = 0;

		while (i < midIndex - startIndex + 1 && j < endIndex - midIndex) 
		{
			if (lowHalf [i] < highHalf [j]) 
			{
				array [k++] = lowHalf [i++];
			} 
			else 
			{
				array [k++] = highHalf [j++];	
			}
		}
		while (j < endIndex - midIndex) 
		{
			array [k++] = highHalf [j++];
		}
		while (i < midIndex - startIndex + 1) 
		{
			array [k++] = lowHalf [i++];
		}

	}

}
