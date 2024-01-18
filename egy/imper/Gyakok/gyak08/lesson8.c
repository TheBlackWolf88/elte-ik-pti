#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#define ROWS 10
#define COLS 10
#define SHIPTYPES 4

//0 - water
//1 - hatar
//2 - hajo

void red () {
  printf("\033[1;31m");
}

void yellow (){
  printf("\033[1;33m");
}

void reset () {
  printf("\033[0m");
}


void init(int tab[ROWS][COLS], int ships[SHIPTYPES]);
void print_table(int tab[ROWS][COLS], int ships[SHIPTYPES]);
int submit(int tab[ROWS][COLS], int ships[SHIPTYPES], char pozX, int pozY, int len, char ori);

int main()
{
    int table[ROWS][COLS];
    int ships[SHIPTYPES];
   
    init(table, ships);
    
    submit(table, ships, 'A', 1, 3, '|');
    submit(table, ships, 'I', 3, 2, '_');
    submit(table, ships, 'I', 4, 3, '_');
    submit(table, ships, 'F', 6, 5, '|');
    submit(table, ships, 'F', 7, 5, '|');
    submit(table, ships, 'A', 1, 2, '_');
    submit(table, ships, 'I', 4, 4, '|');
    submit(table, ships, 'C', 3, 4, '_');
    submit(table, ships, 'G', 9, 3, '_');
    submit(table, ships, 'B', 5, 3, '_');
    submit(table, ships, 'I', 7, 3, '|');
    submit(table, ships, 'J', 7, 2, '|');
    submit(table, ships, 'J', 7, 1, '|');

    print_table(table, ships);
    reset();
    return 0;
}

void init(int tab[ROWS][COLS], int ships[SHIPTYPES]){
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            tab[i][j] = 0;
        }
    }
    for (int i = 0; i < SHIPTYPES; i++) {
        ships[i] = 0;
    }
}

void print_table(int tab[ROWS][COLS], int ships[SHIPTYPES]){
    printf("\n\n");
    printf("\tA\tB\tC\tD\tE\tF\tG\tH\tI\tJ\n\n");
    for (int i = 0; i < ROWS; i++){
        reset();
        printf("%d\t", i+1);
        for (int j = 0; j < COLS; j++) {
            if(tab[i][j] == 2){
                red();
                printf("%d\t", tab[i][j]);
            } else if (tab[i][j] == 1){
                yellow();
                printf("%d\t", tab[i][j]);
            } else {
                reset();
                printf("%d\t", tab[i][j]);
            }
        }
        printf("\n");
    }
    printf("\n\n");
    reset();
    printf("Hajok: ");
    for (int i = 0; i < SHIPTYPES; i++) {
        printf("%d-%d db, ", i+2, ships[i]);
    }
    printf("why?");
}

bool checkLen(int len){
    return len > 5 || len < 2;
}

bool checkOverFlow(int pozX, int pozY, int len, char ori){
    if (ori == '_') return (pozX + len - 1) > COLS;
    if (ori == '|') return (pozY + len - 1) > ROWS;
    return false;
}

void placeBorder(int tab[ROWS][COLS], int posX, int posY, int len, char ori){
    if (ori == '_') {
        for (int i = posY - 2; i <= posY; i++) {
            if (i < 0 || i > 9) continue;
            for(int j = posX - 2; j <= posX+len; j++){
                if (j < 0 || j > 9) continue;
                tab[i][j] = 1;
            }
        }
    } else if (ori == '|'){
        for (int i = posY - 2; i <= posY+len; i++) {
            if (i < 0 || i > 9) continue;
            for (int j = posX - 2; j <= posX; j++) {
                if (j < 0 || j > 9) continue;
                tab[i][j] = 1;
            }
        }
    }
}

bool isShipInWay (int tab[ROWS][COLS], int posX, int posY, int len, char ori){
    if (ori == '_') {
        for (int i = posY - 2; i <= posY; i++) {
            if (i < 0) continue;
            for(int j = posX - 2; j <= posX+len; j++){
                if (j < 0) continue;
                if (tab[i][j] != 0) return false;
            }
        }
        return true;
    } else if (ori == '|'){
        for (int i = posY - 2; i <= posY+len; i++) {
            if (i < 0) continue;
            for (int j = posX - 2; j <= posX; j++) {
                if (j < 0) continue;
                if (tab[i][j] != 0) return false;
            }
        }
        return true;
    } else {
        return 401;
    }

}

void placeShip (int tab[ROWS][COLS], int ships[SHIPTYPES], int posX, int posY, int len, char ori){
    if (ori == '|'){
        for (int i = posY-1; i < posY+len; i++) {
            if (i < 0 || i > 9) continue;
            tab[i][posX-1] = 2;
        }
    } else if (ori == '_') {
        for (int i = posX-1; i < posX+len; i++) {
            if (i < 0 || i > 9) continue;
            tab[posY-1][i] = 2;
        }
    }
}



int submit(int tab[ROWS][COLS], int ships[SHIPTYPES], char pozX, int pozY, int len, char ori){
    int pozXInt = pozX - 'A' + 1; // sorszam (ergo 1-10)
    if (checkLen(len)) {
        printf("Nem szabvany hajomeret! %c%d %d %c\n", pozX, pozY, len, ori);
        return 1;
    } 
    if (checkOverFlow(pozXInt, pozY, len, ori)) {
        printf("Tulcsorog!%c%d %d %c\n", pozX, pozY, len, ori);
        return 1;
    }
    if (isShipInWay(tab, pozXInt, pozY, len, ori)) {
        printf("Hajo az utban!%c%d %d %c\n", pozX, pozY, len, ori);
        return 1; 
    }
    placeBorder(tab, pozXInt, pozY, len, ori);
    placeShip(tab, ships, pozXInt, pozY, len, ori);
    return 0;
}
