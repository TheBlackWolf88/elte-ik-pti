#include <stdio.h>

char change (char ch);

int main(){
    int ch;
    while ( EOF != (ch = getchar())){
        putchar(change(ch));
    }
}

char change (char c){
    if (c == 'a'){
        c = 'e';
    }else if (c == 'e'){
        c = 'i';
    }else if (c == 'i'){
        c = 'o';
    }else if (c == 'o'){
        c = 'u';
    }else if (c == 'u'){
        c = 'a';
    }
    return c;
}
