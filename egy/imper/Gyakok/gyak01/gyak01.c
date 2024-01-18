#include <stdio.h>

int main(){
    char yes[5] = "alma"; //azert 5 mert az utolso a terminalo character;
    char nev[100];
    printf("Neved: ");
    scanf("%s", nev);
    printf("Your name: %s\n", nev);
    printf("sizeof(int) : %ld\n", sizeof(int));
    
    int a = 0;
    int b = 0;
    printf("First: ");
    scanf("%d", &a);
    printf("\nSecond: ");
    scanf("%d", &b);
    printf("%d + %d = %d\n", a, b, a+b);
    printf("%d / %d = %.2f\n", a, b, (float)a/b);

    return 0;
}
