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

	public void CountUnique(int[] arr)
	{
		int n = arr.Length;
		        bool []visited = new bool[n];
     
       		
        	for (int i = 0; i < n; i++)
        	{
     
     	      
        	    if (visited[i] == true)
                	continue;
     
        	    int count = 1;
            		for(int j = i + 1; j < n; j++)
        	 	{
       	         		if (arr[i] == arr[j])
        	 		{
               				visited[j] = true;
                    			count++;
                 		}
            		}
           		
			 Console.WriteLine(arr[i] + "\tFrequency is\t" + count);
        	}
		
	}



	public void CountFrequency(int[] arr)
	{
		

		int[] Frequence = new int[arr.Length];
		
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
			Frequence[i] = 1;

			for(int j = i+1; j < arr.Length; j++)
			{
				if(arr[i] == arr[j])
				{
					Frequence[i] += 1;
				}
			}
		}
		Console.WriteLine("Frequency : ");
		for(int i = 0; i < Frequence.Length; i++)
		{
			if(Frequence[i] > 1)
			{
				Console.WriteLine(arr[i]+" is "+Frequence[i]+" times in Array");
			}
		}

		
		
		
		
	}
	public void MaxAndMin(int[] arr)
	{
		int iMax = 0;
		int iMin = 0;

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
		
		iMax = arr[arr.Length-1];
		iMin = arr[0];

		Console.WriteLine("Maximum is {0} and Minimum is {1}",iMax,iMin);
		
		
		
		
	}


	public static void Main(String[] args)
	{
		Arrays count = new Arrays();
		
		int[] arr = {4, -5, 2, 1, 11, 1, -5, -4, 14, 11, 3, -5, 1, 1, 4};
		
		//Console.WriteLine("\nCount of dublicate Elements is "+count.DublicateS(arr));

		//count.CountFrequency(arr);

		//count.CountUnique(arr);

		count.MaxAndMin(arr);

	}

}