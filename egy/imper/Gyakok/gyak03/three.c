#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void op_chains();
void leap_year();
int guessing_game();

int main(){
    srand(time(NULL));
    //op_chains();
    //leap_year();
    guessing_game(); 

  return 0;
}

int get_target(){
    int diff;
    printf("Choose diff(1-easy, 2-med, 3-hard): ");
    scanf("%d", diff);
    
}

int guessing_game(){
    int secret_number = rand() % 101;
    int tipp;
    printf("generated num: %d\n", secret_number);
    while (1){
        printf("Tipp: ");
        scanf("%d", &tipp);
        if (tipp == secret_number){
            printf("Win\n");
            break;
        }
        else if (tipp > secret_number){
            printf("lower\n");
        }
        else if (tipp < secret_number){ 
            printf("higher\n");
        }
    }
    return 0;
}

void op_chains(){
    
    int a, b, c;
    a = 1;b=1;c=1;
    printf("%d == %d == %d", a,b,c); (( a == b ) ==c ? printf("Treu"): printf("false"));
    a = 1;b=2;c=3;
    printf("%d == %d == %d", a,b,c); (( a == b ) ==c ? printf("Treu"): printf("false"));
    a = 7;b=1;c=0;
    printf("%d == %d == %d", a,b,c); (( a == b ) ==c ? printf("Treu"): printf("false"));
    


}

void leap_year(){
    printf("Gimme a year: ");
    int year;
    scanf("%d", &year);
    (year % 4 == 0 && year % 100 != 0) ? printf("%d is a leap year\n", year) : (year % 400 == 0 ? printf("%d is a leap year\n", year) : printf("No.\n"));
}



void printek(){
    printf("%ld\n", sizeof(int));
    printf("%ld\n", sizeof(long int));
    printf("%ld\n", sizeof(unsigned int));
    printf("%ld\n", sizeof(unsigned long int));
    printf("%ld\n", sizeof(char));
    printf("%ld\n", sizeof(_Bool));
    printf("%ld\n", sizeof(float));
    printf("%ld\n", sizeof(double));
    printf("%ld\n", sizeof(long double));
}


