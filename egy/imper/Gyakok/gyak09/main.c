#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include "my_utils.h"

char* g = "global";
int g2 = 0;

void task();
int task6(int);

int main() {
    srand(time(NULL));
    char* f = "var_main-loc";
    g="variable-global";
    printf("main: %s\t%s\n", g, f);
    task();

    char x = 'x';
    {
        char y = 'y';
        {
            char z = 'z';
            printf("belso blokk: %c\t%c\t%c\n", x, y, z);
        }
        printf("kulso blokk: %c\t%c\n", x, y);
    }
    printf("main blokk: %c\n", x);

    printf("%d", task6(5));

    task8b();
    return 0;

    for(int i = 0; i < 10; i++) task8();
    int* p;
    for(int i = 0; i < 10; i++) p=task8c();
    printf("futasok: %d\n", *p);
    
    int a = 5;
    int b = 10;
    printf("a: %d\nb: %d", a, b);
    swap(&a, &b);
    printf("a: %d\nb: %d", a, b);

    printf("Nagyobb: %d\n", *bigger(&a,&b));
    void nested_swap(int* a, int* b){
        int tmp = *a;
        *a = *b;
        *b = tmp;
    }
    a = 5;
    b = 10;
    printf("a: %d\nb: %d", a, b);
    nested_swap(&a, &b);

}

void task(){
    printf("task: %s\t%s\n",g);

    for(int i = 0; i < 10; i++ ){
        int j = rand() % 3;
        if (j == 2){
            int a = 100;
            printf("%d.: 1. True: %d [%d]", i, j, a);
        } else if (j == 0){
            int b = 100;
            printf("%d.: 1. True: %d [%d]", i, j, b);
        } else {
            int c = 300;
            printf("%d.: 1. True: %d [%d]", i, j, c);
        }
    }
}

int task6(int neg){
    return -neg;
}

void nested_swap(int* a, int* b){
    int tmp = *a;
    *a = *b;
    *b = tmp;
}
