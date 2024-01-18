#ifndef PERSON_H
#define PERSON_H

typedef struct Person {
    char name[30];
    int* age;
} Person;

void printP (Person p);

#endif // !PERSON_H
