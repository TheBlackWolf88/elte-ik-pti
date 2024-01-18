#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "shared.h"
#include "safeio.h"
#include "dyntask.h"

int main(int argc, char *argv[])
{
 /*   char input_str[BUFFER];
    printf("Kerem a szoveget!\n");
    read_string(input_str);
    int n = strlen(input_str)+1;
    char* strc = (char*)malloc(n * sizeof(char));
    if (NULL == strc) {
        printf("sikertelen malloc\n");
        return -1;
    }
    strcpy(strc, input_str);
    printf("masolat: %s\n\n", strc);
    free(strc);
*/
/*    char* p = "Helo";
    printf("p tartalema: %s", p);
    printf("p cime %p, p tartalmanak cime: %p \n", &p, (void*)p);
    p = "Hello world!";
    printf("p tartalema: %s", p);
    printf("p cime %p, p tartalmanak cime: %p \n ", &p, (void*)p);
    char* p2 = p;
    printf("p tartalema: %s", p2);
    printf("p cime %p, p tartalmanak cime: %p \n ", &p2, (void*)p2);

    char source[BUFFER] = "alma";
    char dest[BUFFER];

    char* ptr;
    ptr = reverse_d("Indul a gorog aludni");
    printf("%s", ptr);
    
    free(ptr);*/

    words();
    words();
    return EXIT_SUCCESS;
}
