
#include <cstdlib>
#include <ctime>
#include <iostream>
#include "generateTest.h"

using namespace std;

void generateMajorityArr(int arr[], const int _l){

	srand(time(0));

	int n = (_l / 2	) + 1;
	int majElem = rand() % _l;

	int freeElems = 0;

	for (int k = 0; k < _l; k++){

		if ( (rand()%2 == 0) && (freeElems < _l - n)){

			arr[k] = rand()%_l;
			freeElems += 1;			

		}
		else{
			arr[k] = majElem;
		}

	}
}

void stampa_arr(int a[], const int length, bool reversed){

    if (!reversed) {

        for (int k = 0; k < length; k++) {

            cout << a[k] << " ";

        }

    }

    else{

        for(int k = length - 1; k >= 0; k--){

            cout << a[k] << " ";

        }

    }

    cout << endl;


}