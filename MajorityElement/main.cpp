
#include "generateTest.h"
#include<iostream>

using namespace std;

int ComputeMajorotyElement(int arr[], const int _l){

	int OldestCoupleIndex;
	int OldestCoupleItem;
	int OldestCoupleNums = 0;
	bool OldestCoupleFound = false;

	int tmp;
	int swapIndx;
	int k = 0;

	while (k < _l){

		if (OldestCoupleFound){

			swapIndx = -1;
			
			if (arr[k] != OldestCoupleItem){swapIndx = k;}
			else if (arr[k+1] != OldestCoupleItem){swapIndx = k + 1;}

			if (swapIndx < 0){

				OldestCoupleNums += 1;
				k += 2;
			}
			else{

				tmp = arr[OldestCoupleIndex];
				arr[OldestCoupleIndex] = arr[swapIndx];
				arr[swapIndx] = tmp;

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

}

int main(){

	int l = 10;
	int arr[l];
	
	generateMajorityArr(arr, l);
	
	stampa_arr(arr, l, false);

}