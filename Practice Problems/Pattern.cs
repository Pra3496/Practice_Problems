using System;


public class Pattern
{

	public void Rect(int iCol, int iRow)
	{
		
		
		for(int i = 0; i < iCol; i++)
		{
			for(int j = 0; j < iRow; j++)
			{
				if((i == 0) || (j == 0) || (i == 9) || (j == 9) )
				{
					Console.Write(" * ");
				}
				else
				{
					Console.Write("   ");
				}
			}
			Console.WriteLine();
		}

		
	}

	public void reverseTringle(int iCol, int iRow)
	{
		
		
		for(int i = iCol; i >= 0; i--)
		{
			for(int j = 0; j < i; j++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}

		
	}


	public static void Main(String[] args)
	{
		Pattern pat = new Pattern();
		//pat.Rect(10,10);

		pat.reverseTringle(10,10);
	}

}