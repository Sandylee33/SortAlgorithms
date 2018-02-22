using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort {

	public string LogTestArray(int[] array)
	{
		string s = "";
		foreach (var e in array) 
		{
			s += e.ToString() + ", ";
		}
		Debug.Log(s);
		return s;
	}

	public virtual void sort(int[] array)
	{
		
	}
	public virtual void sort(int[] array,int start, int end)
	{

	}
}
