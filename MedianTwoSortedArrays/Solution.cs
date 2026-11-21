
namespace MedianTwoSortedArrays;


class Solution
{

	private double BaseCase(int[] left, int[] right)
	{
		
		if (left.Length > right.Length)
		{
			int[] tmp = right;
			right = left;
			left = tmp;
		}

		int lMedianIdxRight = (int) Double.Floor( ( (double) right.Length - 1 ) / 2 );
		int rMedianIdxRight = (int) Double.Ceiling( ( (double) right.Length - 1 ) / 2 );

		int lMedianIdxLeft = (int) Double.Floor( ( (double) left.Length - 1 ) / 2 );
		int rMedianIdxLeft = (int) Double.Ceiling( ( (double) left.Length - 1 ) / 2 );

		int lMedianLeft = left[lMedianIdxLeft];
		int rMedianLeft = left[rMedianIdxLeft];

		int lMedianRight = right[lMedianIdxRight];		
		int rMedianRight = right[rMedianIdxRight];

		List<int> solver = new List<int>();

		solver.Add(lMedianLeft);
		if (rMedianLeft != lMedianIdxLeft){solver.Add(rMedianLeft);}

		solver.Add(lMedianRight);
		if (lMedianRight != rMedianRight){solver.Add(rMedianRight);}
		

		if (lMedianIdxRight >= 1){solver.Add(right[lMedianIdxRight - 1]);}
		if (rMedianIdxRight <= right.Length - 2){solver.Add(right[rMedianIdxRight + 1]);}

		int[] solverArray = solver.ToArray();

		solverArray.Sort();

		int lSolver = (int) Double.Floor( ( (double) solverArray.Length - 1 ) / 2 );
		int rSolver = (int) Double.Ceiling( ( (double) solverArray.Length - 1 ) / 2 );

		return ( (double) solverArray[lSolver] + solverArray[rSolver]) / 2;

	
		
	}

	public double FindMedianSortedArrays(int[] left, int[] right)
	{

		double lMedianLeft;
		double rMedianLeft;

		double lMedianRight;
		double rMedianRight;


		if (left.Length == 0)
		{
			lMedianRight = right[ (int) Double.Floor( ( (double) right.Length - 1 ) / 2) ];
			rMedianRight = right[ (int) Double.Ceiling( ( (double) right.Length - 1 ) / 2) ];

			return (lMedianRight + rMedianRight) / 2; 
		}

		if (right.Length == 0)
		{
			lMedianLeft = left[ (int) Double.Floor( ( (double) left.Length - 1 ) / 2) ];
			rMedianLeft = left[ (int) Double.Ceiling( ( (double) left.Length - 1 ) / 2) ];

			return (lMedianLeft + rMedianLeft) / 2; 
		}
		
		int bottomLeft = 0;
		int topLeft = left.Length - 1;

		int bottomRight = 0;
		int topRight = right.Length - 1;

		double lower;
		double upper;
		

		bool IsLowerLeft;
		bool IsUpperLeft;

		int lowerShift;
		int upperShift;
		int delta;

		while ( (topLeft > bottomLeft + 1) && (topRight > bottomRight + 1) )
		{
			
			lMedianLeft = left[ (int) Double.Floor( ( (double) topLeft + bottomLeft ) / 2)];
			rMedianLeft = left[ (int) Double.Ceiling( ( (double) topLeft + bottomLeft ) / 2)];

			lMedianRight = right[ (int) Double.Floor( ( (double) topRight + bottomRight ) / 2) ];
			rMedianRight = right[ (int) Double.Ceiling( ( (double) topRight + bottomRight ) / 2) ];

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
				upper = rMedianLeft;
				IsUpperLeft = true;				
			}

			if (lower >= upper){return lower;}

			if (IsLowerLeft){lowerShift = ( (int) Double.Floor( ((double) topLeft + bottomLeft ) / 2) ) - bottomLeft;}
			else{lowerShift = (int) Double.Floor( ( (double) topRight + bottomRight ) / 2) - bottomRight;}

			if (IsUpperLeft){upperShift = topLeft - (int) Double.Ceiling( ( (double) topLeft + bottomLeft ) / 2);}
			else{upperShift = topRight - (int) Double.Ceiling( ( (double) topRight + bottomRight ) / 2);}

			delta = Math.Min(lowerShift, upperShift);

			if (IsLowerLeft){bottomLeft += delta;}
			else{bottomRight += delta;}

			if (IsUpperLeft){topLeft -= delta;}
			else{topRight -= delta;}

		}

		return BaseCase(left[bottomLeft..(topLeft+1)], right[bottomRight..(topRight+1)]);


	}

}