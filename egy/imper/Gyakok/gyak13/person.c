#include "person.h"
#include <stdio.h>
void printP(Person p){
    printf("A szemely neve: %s, kora: %d\n", p.name, *(p.age));
}
