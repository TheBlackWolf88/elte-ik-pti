#include <ctype.h>
#include <limits.h>
#include <stddef.h>
#include <stdio.h>
#define N 5

void kotelezo(){
    int zeros[N];
    for(int i = 0; i < N; i++){
        zeros[i] = 0;
    }
    printf("[");
    for (int i = 0; i < N; i++){
        printf("%d", zeros[i]);
    }
    printf("]\n");

    int arr[] = {1,554,2,123,6,47,7,24124,745,724,132,24};
    size_t n = sizeof(arr) / sizeof(arr[0]);
    int sum = 0;
    for(int i = 0; i < n; i++){
        sum = sum + arr[i];
    }
    printf("Sum of osszeadando: %d\n", sum);

    int max = arr[0];
    for(int i = 0; i < n; i++){
        if (arr[i] > max) max = arr[i];
    }
    printf("Max val = %d\n", max);

    int min = INT_MAX;
    for(int i = 0; i < n; i++){
        if (arr[i] < min){
            min = arr[i];
        }
    }
    int min2 = INT_MAX;
    for(int i = 0; i < n; i++){
        if(arr[i] < min2 && arr[i] != min){
            min2 = arr[i];
        }
    }
    printf("Second smallest: %d\n",min2);
    
    int sum2 = 0;
    int elso[] = {1,2,3,4,5};
    int masik[] = {6,42,3,5,7};
    double masik2[] = {6.,42.5,3.1,0.5,7.2};
    
    for(int i = 0; i < 5; i++){
        sum2 += elso[i] * masik[i];
    }
    printf("Weighted sum: %d\n", sum2);
    
    double weighted_mean = 0;
    for(int i = 0; i < 5; i++){
        weighted_mean += elso[i] * masik2[i];
    }
    weighted_mean /= 5;
    printf("Weighted avg: %.2f\n", weighted_mean);

    char szo1[] = "alamlevesdoboz";
    char szo2[] = "kutyaporazkepu";

    for(int i = 0; i < sizeof(szo1) / sizeof(szo1[0]); i++){
        if (tolower(szo1[i]) == tolower(szo2[i])) continue;
        else if (tolower(szo1[i]) < tolower(szo2[i])) {
            printf("The first in alphabetical order: %s\n", szo1);
            break;
        }
        else {
            printf("The first in alphabetical order: %s\n", szo2);
            break;
        }
    }

    char beker[1000];
    scanf("%s", beker);
    size_t m = 0;
    while(beker[m] != '\0'){
        m++;
    }
    printf("Length of string: %lu\n", m);
}

void gyak (){
    int arr1[] = {1,5,6,72,53,1,-432,2};
    int maxind = 0;
    int minind = 0;
    for(int i = 0; i < 8; i++){
        if (arr1[i] < arr1[minind]){
            minind = i;
        }
    }
    for(int i = 0; i < 8; i++){
        if (arr1[i] > arr1[maxind]) maxind = i;
    }
    int a = arr1[maxind];
    arr1[maxind] = arr1[minind];
    arr1[minind] = a;

    int cnl = 0;
    char word[100];
    scanf("%s", word);
    int j = 0;
    while (word[j] != '\0'){
        if(word[j] == '\n'){
            cnl++;
        }
        j++;
    }
    printf("Lines: %d", cnl);
    
} 

int main () {
    kotelezo();
    gyak();
}
