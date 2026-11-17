
class Solution
{

	public double FindMedianSortedArrays(int[] left, int[] right)
	{
		
		int bottomLeft = 0;
		int topLeft = left.Length - 1;

		int bottomRight = 0;
		int topRight = right.Length - 1;

		double lower;
		double upper;

		double lMedianLeft;
		double rMedianLeft;

		double lMedianRight;
		double rMedianRight;

		bool IsLowerLeft;
		bool IsUpperLeft;

		int lowerShift;
		int upperShift;
		int delta;

		while ( (topLeft >= bottomLeft + 1) && (topRight >= bottomRight + 1) )
		{
			
			lMedianLeft = left[ (int) Double.Floor( (topLeft + bottomLeft) / 2)];
			rMedianLeft = left[ (int) Double.Ceiling( (topLeft + bottomLeft) / 2)];

			lMedianRight = right[ (int) Double.Floor( (topRight + bottomRight) / 2) ];
			rMedianRight = right[ (int) Double.Ceiling( (topRight + bottomRight) / 2) ];

			if (lMedianLeft <= lMedianRight)
			{
				lower = lMedianLeft;
				IsLowerLeft = true;
			}
			else
			{
				lower = lMedianRight;
				IsLowerLeft = false;				
			}
			

			if (rMedianLeft <= rMedianRight)
			{
				upper = rMedianRight;
				IsUpperLeft = false;
			}
			else
			{
				upper = lMedianRight;
				IsUpperLeft = true;				
			}

			if (lower >= upper){return lower;}

			if (IsLowerLeft){lowerShift = ( (int) Double.Floor( (topLeft + bottomLeft) / 2) ) - bottomLeft;}
			else{lowerShift = (int) Double.Floor( (topRight + bottomRight) / 2) - bottomRight;}

			if (IsUpperLeft){upperShift = topLeft - (int) Double.Ceiling( (topLeft + bottomLeft) / 2);}
			else{upperShift = topRight - (int) Double.Ceiling( (topRight + bottomRight) / 2);}

			delta = Math.Min(lowerShift, upperShift);

			if (IsLowerLeft){bottomLeft += delta;}
			else{bottomRight += delta;}

			if (IsUpperLeft){topLeft -= delta;}
			else{topRight -= delta;}

								


		}



	}

}
