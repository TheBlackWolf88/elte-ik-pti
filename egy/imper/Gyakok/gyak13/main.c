#include "box.h"
#include "person.h"
#include <string.h>
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>

int main()
{

    Person p1;
    strcpy(p1.name, "Aladar");
    int ev = 21;
    p1.age = &ev;
    Person p2 = p1;
    printP(p1);
    printP(p2);
    strcpy(p1.name, "Boldizsar");
    ev=32;
    printP(p1);
    printP(p2);

/*
    init();

    if (is_empty()) {
        printf("A verem ures\n");
    }
    else {
        printf("A verem nem ures\n");
    }

    printf("\n= Peek =\n");
    printf("A legfelso ertek: %d\n", peek());

    printf("\n= Push =\n");
    push(7);
    push(3);
    push(6);
    push(1);
    printf("A legfelso ertek: %d\n", peek());
    pop();
    printf("A legfelso ertek: %d\n", peek());
    
    init();
    push(12);
    push(42);
    printf("A legfelso ertek: %d\n", peek());
    printf("Merete: %d\n", length());
    copy_top();
    printf("A legfelso ertek: %d\n", peek());
    printf("Merete: %d\n", length());
    destroy();
*/

    return EXIT_SUCCESS;
}
