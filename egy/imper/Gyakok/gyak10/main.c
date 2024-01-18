#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>
#include "stringwork.h"
#include "fileio.h"
#include "shared.h"

int main(int argc, char *argv[])
{
    printf(">> Szia from %s\n", argv[0]);
    printf(">> Parameterek szama: %d\n", argc);

    int menu;
    int mode = 0;
//ell
    
    if(argc <= 1){
        printf(">> kerem a feladat szamat: ");
        scanf("%d", &menu);
        getchar();
    } else {
        if (argc >= 2) menu = atoi(argv[1]);
        if (argc > 2) mode = atoi(argv[2]);
    }

    printf(">> %d feladat futtatase (%s modeban)\n\n", menu, (mode==0)?"beepitett":"sajat");

    char input[BUFFER];
    char input2[BUFFER];
    switch (menu) {
        case 1:
            printf("Kerek egy mondatot: \n");
            read_string(input);
            int chars = 0;
            int words = 0;
            counter(input, &chars, &words, mode);
            printf("A karakterek: %d - szavak: %d\n\n", chars, words);
            break;
        case 2:
            printf("Elso szo: \n");
            read_string(input);
            printf("Masodik szo: \n");
            read_string(input2);
            int res = strcmp(input, input2);
            printf("Eredmeny: %d\n", res);
            break;
        case 3:
            break;
        case 4:
            mod_str();
            break;
        case 5:
            file_read();
            break;
        case 6:
            file_rw();
            break;
    }


    printf(">> Viszlat!\n");

    return 0;
}
