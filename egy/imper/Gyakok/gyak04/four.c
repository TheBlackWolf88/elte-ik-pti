#include <stdio.h>
#include <ctype.h>
#include <math.h>
#include <stdlib.h>

#ifndef M_PI
#define M_PI 3.1415926
#endif

void muveletek();
void little_big ();
void circle ();
void datev1();
void coords ();
void switcheroo();
void negacio();
int main (){
 //   muveletek();
//    little_big();
//    circle();
//    datev1();
//      coords();
//    switcheroo();
    negacio();
}

void operator ( void ) {
    int i = 3;
    int j = ++i;

    printf("++i : %d", j);

    i = 3;
    j = i++;
    printf("i++ : %d", j);
}

void muveletek(){
    int a;
    int b;
    printf("a= ");
    scanf("%d", &a);
    printf("b= ");
    scanf("%d", &b);

    printf("a + b = %d\n", a + b);
    printf("a - b = %d\n", a - b);
    printf("a * b = %d\n", a * b);
    printf("a / b = %d\n", a / b);
    printf("a mod b = %d\n", a % b);
}

void little_big( void ){
    char l;
    do {
        printf("Input letter: ");
        scanf(" %c", &l);
        if(isalpha(l)){
            isupper(l) ? printf("Lower: %c\n", tolower(l)) : printf("Bigger: %c\n", toupper(l));
        } else if (l != '0'){
            printf("Not a letter\n");
        }
    } while ( l != '0');
    printf("Exiting..\n");
}

void circle() {
    int r;
    printf("r = ");
    scanf("%d", &r);
    int d = 2 * r;
    double K = 2 * r * M_PI;
    double T = r * r * M_PI;

    printf("r = %d\nd = %d\nK = %.2f\nT = %.2f\n", r,d,K,T);
}

void datev1 () {
    printf("Input your date (yyyymmdd) : ");
    int date;
    scanf("%d", &date);
    int year = date / 10000;
    int month = (date - (year * 10000)) / 100;
    int day = date - (year * 10000) - month * 100;
    printf("The date is : %d. %d. %d.\n", year, month, day);
    
}

void switcheroo () {
    int a;
    int b;
    printf("Num1: ");
    scanf("%d", &a);
    printf("Num2: ");
    scanf("%d", &b);

    int diff = abs(a-b);
    if(a > b) {
        a = a - diff;
        b = b + diff;
    } else {
         a = a + diff;
        b = b - diff;
    }

    printf("a: %d, b: %d\n", a, b);
}

void negacio () {
    printf("Num: ");
    int a;
    scanf("%d", &a);
    a = ~a;
    printf("a: %d\n", a);
}
