#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#define FBUFFER 256


void file_read ( void ){
    FILE* fin;
    char filename[] = "autok.txt";
    fin = fopen(filename, "r");
    if (fin == NULL){
        printf("Nem talalhato az allomany!\n");
        return;
    }

    char row[FBUFFER];
    while (fgets(row, FBUFFER, fin)) {
        int i=0;
        while(row[i] != '\0'){
            row[i] = toupper(row[i]);
            i++;
        }
        printf("%s", row);
    }
    fclose(fin);

}

void file_rw ( void ){
    FILE* fin;
    FILE* fout;
    char filename[] = "autok.txt";
    char filename2[] = "autok_nagy.txt";
    fin = fopen(filename, "r");
    fout = fopen(filename2, "w"); //csak ir, fajl elejetol
    //fout = fopen(filename2, "a"); // fajl vegetol ir
    if (fin == NULL){
        printf("Nem talalhato az allomany!\n");
        return;
    }

    char row[FBUFFER];
    while (fgets(row, FBUFFER, fin)) {
        int i=0;
        while(row[i] != '\0'){
            row[i] = toupper(row[i]);
            i++;
        }
        fprintf(fout, "%s", row);
    }
    fclose(fin);
    fclose(fout);

}
