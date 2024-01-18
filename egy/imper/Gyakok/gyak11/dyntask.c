#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "shared.h"
#include "safeio.h"

void reverse(char* t){
    size_t n = strlen(t);
    for(size_t i = 0; i < n/2; i++){
        char tmp = t[i];
        t[i] = t[n-1-i];
        t[n-1-i] = tmp;
    }
}

char* reverse_d(char* t){
   size_t n = strlen(t)+1;

   char* newt = calloc(n, sizeof(char));
   if(newt == NULL){return NULL;}

   memset(newt, '\0', n);
   
   for (size_t i =0; i < n-1; i++) {
        *(newt + n -2 -i) = *(t+i);
   }
   return newt;
}

void words (void){
    char** storage = NULL;
    printf("Johetnek a szavak EOFig\n");
    int i = 0;
    char word[BUFFER];
    while (read_string(word) != NULL) {
        if (i % GROW == 0){
            char** temp = realloc(storage, i+GROW * sizeof(*storage));
            if(temp == NULL){
                printf("Sikertelen realloc\n");
                return;
            }
            storage = temp;
        }
        storage[i] = malloc(sizeof(strlen(word) + 1));
        if (storage[i] == NULL){
            printf("Sikertelen malloc\n");
            return;
        }
        strcpy (storage[i], word);
        i++;
    }
    printf("Beolvasa kesz: %d\n", i);
    for (int j = i-1; j >= 0; --j) {
        printf("Szo %d : %s\n", j+1, storage[j]);
    }

    for (int j = 0; j < i;j++) {
        free(storage[j]);
    }
    free( storage );
}


