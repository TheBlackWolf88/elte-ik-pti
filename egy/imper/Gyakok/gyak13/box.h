#ifndef BOX_H
#define BOX_H

#include <stdbool.h>

void init();

bool is_empty();

int peek();

void push (int _weight);

void pop();

void destroy();

int length();

void copy_top();

#endif // !BOX_H
