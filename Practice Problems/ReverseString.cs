using System;


public class StringDemo
{

	public String ReverseStr(String str)
	{
		int j = 0;
		char[] cArr = str.ToCharArray();
		char[] cNewArr = new char[cArr.Length];

		for(int i = cArr.Length-1; i >= 0; i--)
		{
			cNewArr[j++] = cArr[i];
		}

		String NewStr = new String(cNewArr);
		
		return NewStr;
	}

	public static void Main(String[] args)
	{
		StringDemo strdemo = new StringDemo();
		
		String str = "I am Pranav Waghmare";
		
		Console.WriteLine(strdemo.ReverseStr(str));
	}


}


	