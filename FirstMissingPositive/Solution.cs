
namespace FirstMissingPositive;


public class Solution()
{

	public int FirstMissingPositive(int[] arr)
	{

		int posMin = int.MaxValue;
		int _l = arr.Length;

		for (int k = 0; k < _l; k++)
		{
			if ( (arr[k] > 0) && (arr[k] < posMin)){posMin = arr[k];}
		}

		if (posMin != 1){return 1;}

		for (int k = 0; k < arr.Length; k++)
		{

			bool endCycle = false;

			int activeIndx = k;
			int activeValue = arr[activeIndx];

			while (!endCycle)
			{

				int correctIndex = activeValue - posMin;

				if (correctIndex == activeIndx){endCycle = true;}
				else if (correctIndex >= _l){endCycle = true;}
				else
				{

					//save whatever is stored here
					int tmp = arr[correctIndex];

					//place the current active value at its correct index
					arr[correctIndex] = activeValue;

					//change the active value and set the correct index
					activeValue = tmp;
					activeIndx = correctIndex;
				}
			}
		}

		int candidateRet = posMin + 1;

		for (int k = 1; k < _l; k++)
		{			
			if (arr[k] != candidateRet){return candidateRet;}
			else{candidateRet += 1;}
		}

		return posMin + _l;
	}
	

}