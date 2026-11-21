
namespace MedianTwoSortedArrays;

public class Test
{
	
	public static void Main()
	{
		
		int[] l = [-10, -9, -8];
		int[] r = [1, 2];

		Solution sol = new Solution();
		double x = sol.FindMedianSortedArrays(l, r);

		Console.WriteLine(x);

	}

}