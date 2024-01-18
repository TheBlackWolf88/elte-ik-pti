#include <stdio.h>


int main(){
    int ch;
    while (EOF != (ch = getchar())){
        putchar(ch);
    }
    return 0;
}
