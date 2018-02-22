using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSort : Sort{

	void Swap(int[]array,int firstNum, int secondNum)
	{
		int temp = array[firstNum];
		array[firstNum] = array[secondNum];
		array[secondNum] = temp;
	}

	int indexOfMinimum(int[]array,int startIndex)
	{
		int minValue = array [startIndex];
		int minIndex = startIndex;
		for (int i = minIndex + 1; i < array.Length; i++) 
		{
			if (array [i] < minValue) 
			{
				minIndex = i;
				minValue = array [i];
			}
		}
		return minIndex;
	}


	public override void sort(int[] array)
	{
		int index = 0;
		for (int i = 0; i < array.Length; i++) 
		{
			index = indexOfMinimum (array, i);
			Swap (array, i, index);
		}
	}




}
