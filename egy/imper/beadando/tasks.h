#ifndef TASKS_H
#define TASKS_H

#include <stdio.h>
void get_help(void);
int *alloc_matrix(int n, int *mat);
int *generate_matrix(int n, int *mat, int dir, int rot);
void print_matrix(int n, int *mat);
int save_mat(int n, int *mat, int dir, int rot);
int *load_mat(int* mat, int n, FILE* f);

int get_kezdo(int n, int rot, int dir);
int get_new_dir(int rot, int dir);
int get_new_ind(int dir, int ind, int n);
int fel(int ind, int n);
int le(int ind, int n);
int bal(int ind);
int jobb(int ind);
#endif // !TASKS_H
