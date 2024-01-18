#include <stddef.h>
#include <stdio.h>
#define BUFFER 100
int arr_sum(int arr[], size_t n){
    int sum = 0;
    for(int i = 0; i < n; i++){
        sum += arr[i];
    }
    return sum;
}

int arr_sum2(int* arr, int* end){
    int sum = 0;
    for(; arr < end ; arr++){
        sum += *arr;
    }
    return sum;
}

void print_arr(int* arr, int* end){
    for(; arr < end; arr++){
        printf("%d,", *arr);
    }
    printf("%d,", *arr);
}

int arr_avg(int* start, int* end){
    int avg = 0;
    for(int* arr = start; arr < end; arr++){
        avg += *arr;
    }
    avg += *end;
    return avg / (end-start);

}

int* local_point(){
    int local = 4;
    int* lp = &local;
    return lp;
}

int p_comparator(int* a, int* b){
    return (a > b) - (a < b);
}

int main() { 
    /*
    int* p;
    int * p;
    int *p;
    */
/*
    int c =3;
    printf("A c cime: %p, erteke: %d\n", (void*)&c, c);
    int *p = &c;
    printf("A p cime: %p, erteke: %d\n", (void*)p, *p);
    printf("A p cime(bonyi): %p, erteke: %d\n", (void*)(&(*p)), *p);
    c++;
    printf("A c cime: %p, erteke: %d\n", (void*)&c, c);
    printf("A p cime: %p, erteke: %d\n", (void*)p, *p);
    printf("A p cime(bonyi): %p, erteke: %d\n", (void*)(&(*p)), *p);
    (*p)++;
    printf("A c cime: %p, erteke: %d\n", (void*)&c, c);
    printf("A p cime: %p, erteke: %d\n", (void*)p, *p);
    printf("A p cime(bonyi): %p, erteke: %d\n", (void*)(&(*p)), *p);
    p++;
    printf("A c cime: %p, erteke: %d\n", (void*)&c, c);
    printf("A p cime: %p, erteke: %d\n", (void*)p, *p);
    printf("A p cime(bonyi): %p, erteke: %d\n", (void*)(&(*p)), *p);
*/ 
    int* lp = local_point();
    printf("a lok valt cime: %p erteke: %d", (void *)lp, *lp);
    
    int j = 11;
    int *p1 = &j;
    int *p2 = p1;
    int **p3 = &p1;
    printf("eredeti j: %d\n", j);
    printf("p2 inc j: %d\n", ++(*p2));
    printf("p3 inc j: %d\n", ++(**p3));

    void* pv = &pv;
    printf("Int*: %zu\n", sizeof(int*));
    printf("Char*: %zu\n", sizeof(char*));
    printf("Double*: %zu\n", sizeof(double*));
        
    int arr[] = {1,2,3,4,5,1,2,3,4,5};
    size_t n = sizeof(arr) / sizeof(*arr);

    printf("Elemek osszege: %d\n", arr_sum(arr, n));
    printf("Elemek osszege: %d\n", arr_sum2(arr, arr+n));
    print_arr(arr, arr+n);
    printf("Elemek atlaga: %d\n", arr_avg(arr, arr+n));
    printf("Elemek atlaga: %d\n", (int)(arr_sum2(arr, arr+n)/ n));
    

    int loc = 5;
    {
        int loc = 15;
        printf("A c cime: %p, erteke: %d\n", (void*)&loc, loc);
    }
        printf("A c cime: %p, erteke: %d\n", (void*)&loc, loc);
    printf("a lok valt cime: %p erteke: %d", (void *)lp, *lp);
    
    int* pNull = NULL;
    if (pNull != NULL) {
        printf("ertek: %d\n", *pNull);
    } else {
        printf("nullptrexception");
    }

    int p10[BUFFER];
    int* p20 = p10;
    p20 += 3;

    switch (p_comparator(p10, p20)) {
        case 1:
            printf("p10\n");
            break;
        case 0:
            printf("p10=p20\n");
            break;
        case -1:
            printf("p20");
            break;
        default:
            printf("something went wronk");
            break;
    }
    printf("a lok valt cime: %p erteke: %d", (void *)lp, *lp);
}

