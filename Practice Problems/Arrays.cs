using System;
using System.Collections.Generic;

public class Arrays
{

	public int Dublicates(int[] arr)
	{
		int isum = 0;

		List<int> dublicate = new List<int>();
		
		for(int i = 0; i < arr.Length; i++)
		{
			for(int j = i+1; j < arr.Length; j++)
			{
				if(arr[i] > arr[j])
				{
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp; 
				}
			}
		}

		for(int i = 0; i < arr.Length; i++)
		{
			for(int j = i+1; j < arr.Length; j++)
			{
				if(arr[i] == arr[j])
				{
					dublicate.Add(arr[i]);
					isum++;
				}
			}
		}
		Console.Write("Dublicate Elements : ");
		foreach(int i in dublicate)
		{
			Console.Write("\t"+i);
		}

		
		
		
		return isum;
	}


	


	public static void Main(String[] args)
	{
		Arrays count = new Arrays();
		
		int[] arr = {4, -5, 2, 1, 11, 1, -5, -4, 14, 11, 3, -5, 1, 1, 4};
		
		//Console.WriteLine("\nCount of dublicate Elements is "+count.DublicateS(arr));

		//count.CountFrequency(arr);

		count.CountUnique(arr);

	}

}