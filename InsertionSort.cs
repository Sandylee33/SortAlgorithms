using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort : Sort{

	void Insert(int[] array, int rightIndex, int value)
	{
		int i = rightIndex;
		while (i >= 0 && array [i] > value) 
		{
			array [i + 1] = array [i];
			i--;
		}
		array [i + 1] = value;
	}

	public override void sort(int[] array)
	{
		for (int i = 0;i < array.Length - 1;i++)
		{
			Insert (array, i, array [i + 1]);
		}
	}


}
