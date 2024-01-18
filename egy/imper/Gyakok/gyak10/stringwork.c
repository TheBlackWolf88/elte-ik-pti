#include <stdio.h>
#include <ctype.h>
#include <string.h>
#include "shared.h"


void read_string(char str[]){
    fgets(str, BUFFER, stdin);
    printf("%s -> meret: %zu\n", str, strlen(str));

    if(strchr(str, '\n') != NULL){
        *strchr(str, '\n') = '\0';
    } else {
        int c;
        while ((c=getchar()) != EOF && c != '\n');
    }
}

void counter(char str[], int *c, int *w, int mode){
    if (mode == 1){
        char* p = str;
        while (*p != '\0') {
            p++;
        }
        *c = p-str;
    } else {
        *c = strlen(str);
    }

    for (int i = 0; str[i]!='\0'; i++) {
        if(!isspace(str[i]) && ( isspace(str[i+1]) || str[i+1] == '\0') ) (*w)++;
    }
}

void mod_str(){
    char t[] = "1 - Tomb string";
    char* p = "2 - Pointer string";

    printf("%s\n", t);
    printf("%s\n", p);
    
    //Tombkent modosithato
    t[0] = 'A';
    t[9] = 'S';
    printf("%s\n", t);
    
    //Pointeren keresztul
    printf("%c %c\n", *(p+0), *(p+12));
//    *(p+0) = 'B';
//    *(p+12) = 'S'; //SEGFAULT MORE, ILYET NE PLSS
    printf("%s\n", p);
    
}
