
namespace MedianTwoSortedArrays;

public class Test
{
	
	public static void Main()
	{
		
		int[] l = [1,2,3,4,5];
		int[] r = [6,7,8,9,10,11,12,13,14,15,16,17];

		double x = Solution.FindMedianSortedArrays(l, r);

		Console.WriteLine(x);

	}

}