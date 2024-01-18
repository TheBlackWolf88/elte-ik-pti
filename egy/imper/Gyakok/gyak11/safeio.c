#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>

#include "shared.h"
void clear_stream(){
    int c;
    while ((c=getchar()) != EOF && c != '\n');

}
char* read_string(char str[]){
    char* c = fgets(str, BUFFER, stdin);
    if (c == NULL) return c;

    if(strchr(str, '\n') != NULL){
        *strchr(str, '\n') = '\0';
    } else {
        clear_stream();
    }
    printf("%s -> meret: %zu\n", str, strlen(str));
    return c;
}


