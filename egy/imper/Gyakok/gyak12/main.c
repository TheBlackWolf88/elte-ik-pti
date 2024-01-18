#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include "student.h"
#include <time.h>
#define SIZE 6


int main()
{
    srand (time (NULL));
    MyStud** arr_heap = malloc(SIZE * sizeof(MyStud));

    if(arr_heap == NULL){
        printf("malloc err\n");
        return -1;
    }
    for(int i = 0; i < SIZE; i++){
        arr_heap[i] = student_init(i, rand()%3);        
    }

    for (int i = 0; i < SIZE; i++) {
        printS(*arr_heap[i]); 
    }
    for (int i = 0; i < SIZE; i++) {
        free(arr_heap[i]);
    }
    free(arr_heap);
}
