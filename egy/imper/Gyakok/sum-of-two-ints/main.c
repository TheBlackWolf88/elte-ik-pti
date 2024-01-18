#include <assert.h>
#include <errno.h>
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>

int sumOfTwoInts()
{
	int arr[] = {1,2,3,5,-6,-2,15};
	size_t len = sizeof(arr)/sizeof(*arr);
	int n = 7;

	for (int i = 0; i < len; i++){
	    for(int j=0; j < len; j++){
		if(arr[j]+arr[i] == n){
			printf("arr[%d]: %d\n", i, arr[i]);
			printf("arr[%d]: %d\n", j, arr[j]);
			return 1;
		}
	    }
	}
	return 0;
}

int main(){
	int res = sumOfTwoInts();

	printf("%d\n", res);
}


