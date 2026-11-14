
namespace FirstMissingPositive;
public class genIntArray()
{

	public static int[] newArr(int _l)
	{
	
		int[] ret = new int[_l];

		Random rnd = new Random();
		int flip = 0;

		for (int k = 0; k < _l; k++)
		{
			flip = rnd.Next(0, 2);

			if (flip == 0){ret[k] = rnd.Next();}
			else{ret[k] = -rnd.Next();}			
		}

		return ret;
	}

	public static void print(int[] arr)
	{
		String tmpString = "";
		int _l = arr.Length;

		for (int k = 0; k < _l - 1; k++){

			tmpString += arr[k];
			tmpString += ", ";
		}

		tmpString += arr[_l - 1];

		Console.WriteLine(tmpString);
	} 	


}