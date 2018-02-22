using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortTestScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		int[] testArray = {2, 1, 4, 6, 7, 12, 66, 54, 78, 35, 165};
		//SelectionSortTest(testArray);
		//InsertionSortTest(testArray);
		//MergeSortTest(testArray);
		QuickSortTest(testArray);
	}

	void SelectionSortTest(int[] array)
	{
		SelectionSort SS = new SelectionSort ();
		SS.LogTestArray (array);
		SS.sort (array);
		SS.LogTestArray (array);
	}

	void InsertionSortTest(int[] array)
	{
		InsertionSort IS = new InsertionSort ();
		IS.LogTestArray (array);
		IS.sort (array);
		IS.LogTestArray (array);
	}
	void MergeSortTest(int[] array)
	{
		MergeSort MS = new MergeSort();
		MS.LogTestArray (array);
		MS.sort (array,0,array.Length-1);
		MS.LogTestArray (array);
	}

	void QuickSortTest(int[] array)
	{
		QuickSort QS = new QuickSort ();
		QS.LogTestArray (array);
		QS.sort (array,0,array.Length-1);
		QS.LogTestArray (array);
	}
}
