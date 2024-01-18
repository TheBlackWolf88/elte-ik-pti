#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>
#include <math.h>

void get_target();
void guessing();
bool evaluate();
int secret_number;

int main(){
    srand(time(NULL));
    get_target();
    guessing();
}

void get_target(){
    int diff;
    printf("Choose diff(1-easy, 2-med, 3-hard): ");
    scanf("%d", &diff);
    int max;
    switch (diff){
        case 1:
            max = 11;
            break;
        case 2:
            max = 101;
            break;
        case 3:
            max = 10001;
            break;
    }
    secret_number = rand() % max;
}

void guessing(){
    int tipp;
    printf("generated num: %d\n", secret_number);
    while (1){
        printf("Tipp: ");
        scanf("%d", &tipp);
        if(evaluate(tipp)) break; 
    }
}

bool evaluate(int tipp){
    if (tipp == secret_number){
        printf("Win\n");
        return true;
    }
    else if (tipp > secret_number){
        printf("lower\n");
        return false;
    }
    else if (tipp < secret_number){ 
        printf("higher\n");
        return false;
    }
}
