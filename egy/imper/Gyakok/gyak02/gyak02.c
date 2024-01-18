#include <stdio.h>
#include <stdbool.h>
#include <math.h>
#include <limits.h>

int main () {
    /*
    const int num = 8;

    if (num % 2 == 0) {
        printf("%d is even.\n", num);
    }
    else {
        printf("%d is not even.\n", num);
    }

    int num2 = 2;
    printf("Number: ");
 //   scanf("%d", &num2);
    
    if (num2 > 0) printf("%d is positive\n", num2);
    else {
        if(num2 < 0) printf("%d is negative\n", num2);
        else printf("Number is 0\n");
    }

    int num3 = 12;
    printf("%d\n", num3);
    
    num3 = 4.5;
    printf("%d\n", num3);
    
    num3 = 'c';
    printf("%d\n", num3);
    num3 = true; printf("%d\n", num3);
    
    num3 = "alma";
    printf("%d\n", num3);


    float num4 = 4.5;
    printf("%f\n", num4);
    
    num4 = 12;
    printf("%f\n", num4);
    
    num4 = 'c';
    printf("%f\n", num4);
    
    num4 = true;
    printf("%f\n", num4);
    
    //num4 = "alma";
    //printf("%f\n", num4);
   
    int n;
    printf("size of int: %ld\n", sizeof(n));
    int min = -1 * pow(2,31);
    int max = pow(2, 31) - 1;
    
    printf("Max: %d, min: %d\n", INT_MAX, INT_MIN);

    int n1 = 5;
    int n2 = 10;
    
    float avg = ((float) n1 + (float) n2)/2;

    printf("Average: %.1f\n", avg);

    */

    //Not safe
/*    for(float i = 0; i <= 1.0; i+=0.1){
        printf("%f\n", i);
    }
*/

    for(int i = 0; i <= 10; i++){
        printf("%f\n", (float) i /10);
    }
    
    int a,b;
    scanf("%d %d", &a, &b);
    lnko(a,b);

    return 0;
}

void lnko(int a, int b){
    a = (a>=0) ? a : a * -1;
    b = (b>=0) ? b : b * -1;
    
    int larger = (a>b) ? a : b;

    int yes;

    for (int i = 1; i <= larger; i++){
        if(a % i == 0 && b % i == 0) yes = i;
    }

    printf("%d lnko %d: %d\n", a, b, yes);

    int aa = a;
    int bb = b;

    while (aa != bb){
        if(aa > bb){
            aa -= bb;
        } else {
            bb -= aa;
        }
    }

    printf("lnko: %d\n", bb);

    int temp;
    while(b > 0){
        temp = b;
        b = a % b;
        a = temp;
    }

    printf("lnko: %d\n", a);
}
