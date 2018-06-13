using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : Sort {

	void swap(ref int a, ref int b)
	{
		int c = a;
		a = b;
		b = c;
	}

	public override void sort (int[] array)
	{   
		bool swapped = false;
		for (int i = 0; i < array.Length - 1; i++) 
		{
			if (array [i] < array [i + 1]) 
			{
				swap (ref array [i],ref array [i + 1]);
				swapped = true;
			}
	    }
		if (swapped) 
		{
			sort (array);
		}

	}
}
