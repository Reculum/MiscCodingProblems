
#include "generateTest.h"
#include<iostream>

using namespace std;

int ComputeMajorotyElement(int arr[], const int _l){

	int OldestCoupleIndex;
	int OldestCoupleItem;
	int OldestCoupleNums = 0;
	bool OldestCoupleFound = false;

	int swapIndx;
	int k = 0;

	while (k + 1 < _l){

		if (OldestCoupleFound){

			swapIndx = -1;
			
			if (arr[k] != OldestCoupleItem){swapIndx = k;}
			else if (arr[k+1] != OldestCoupleItem){swapIndx = k + 1;}

			if (swapIndx < 0){

				OldestCoupleNums += 1;
				k += 2;
			}
			else{

				arr[OldestCoupleIndex] = arr[swapIndx];
				arr[swapIndx] = OldestCoupleItem;

				//stampa_arr(arr, _l, false);

				OldestCoupleNums -= 1;

				if (arr[k] == arr[k+1]){OldestCoupleNums += 1; k += 2;}

				if (OldestCoupleNums == 0){OldestCoupleFound = false; k +=2;}
				else{OldestCoupleIndex += 2;}
			}

		}
		else{

			if (arr[k] == arr[k+1]){

				OldestCoupleFound = true;
				OldestCoupleIndex = k;
				OldestCoupleItem = arr[k];
				OldestCoupleNums += 1;
			}

			k += 2;
		}

		
	}

	
	if ( (_l % 2 == 0) || (OldestCoupleNums != 0)){return OldestCoupleItem;}
	else{return arr[_l - 1];}
}

int main(){

	int l = 100;
	int arr[l];

	int seed = time(0);
	
	generateMajorityArr(arr, l, seed);
	stampa_arr(arr, l, false);

	cout << ComputeMajorotyElement(arr, l) << endl;

}