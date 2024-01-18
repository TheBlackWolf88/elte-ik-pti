#include "box.h"
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>

typedef struct Box box;

struct Box {
    int weight;
    box* next;
};

static box* top;

void destroy(){
    while (!is_empty()) {
        pop();
    }
}

void init(){
    destroy();
    top = NULL;
}

bool is_empty(){
    return top == NULL;
}

int peek(){
    if(is_empty()) return -1;
    return top->weight;
}

void push(int _weight){
    box *b = malloc(sizeof(box));
    if(b == NULL){
        printf("Malloc ERROR\n");
        return;
    }
    b->weight = _weight;
    b->next = top;
    top = b;

}

void pop(){
    if (is_empty()) {
        return;
    }
    box* old_top = top;
    top = top->next;
    free(old_top);
}

int length(){
    if (is_empty()) return 0;
    box* iter = top;
    int n = 1;
    while (iter->next != NULL) {
        iter = iter->next;
        n++;
    }
    return n;
}

void copy_top(){
    if(is_empty()) return;
    push(top->weight);
}
