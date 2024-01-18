#include <stdio.h>

extern char* g;
static int g2 = 12;

void task8(){
    static int counter = 0;
    counter++;
    printf("stat valt: %d\n", counter);
}
void task8b(){
    printf("glob: %s\n", g);
    printf("static glob: %d\n", g2);
}
int* task8c(){
    static int counter = 0;
    counter++;
    return &counter;
}
void swap(int* a, int* b){
    int tmp = *a;
    *a = *b;
    *b = tmp;
}
int* bigger(int* a, int* b){
    return (*a>*b) ? a : b;
}
