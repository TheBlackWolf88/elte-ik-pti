#include "tasks.h"

#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>

int *alloc_matrix(int n, int *mat) {
  int *new_ptr = (int *)realloc(mat, n * n * sizeof(int));
  return new_ptr;
}

int *generate_matrix(int n, int *mat, int dir, int rot) {
  mat = alloc_matrix(n, mat);

  for (int i = 0; i < n * n; i++) {
    mat[i] = 0;
  }

  if (mat == NULL)
    exit(137);
  int elem = 1;
  int lepes = 1;
  int kor = 0;
  // printf("n: %d, rot: %d, dir: %d\n", n, rot, dir);
  int ind = get_kezdo(n, rot, dir);
  if (ind == -1)
    // realistically wont ever happen
    return mat;
  mat[ind] = elem++;
  while (lepes < n) {
    for (int i = 0; i < lepes; i++) {
      ind = get_new_ind(dir, ind, n);
      mat[ind] = elem++;
    }

    dir = get_new_dir(rot, dir);
    kor++;
    if (kor == 2 && lepes != n - 1) {
      lepes++;
      kor = 0;
    }
    if (kor == 3 && lepes == n - 1)
      break;
  }
  printf("Generation successful!\n");
  return mat;
}

int get_kezdo(int n, int rot, int dir) {
  if (n % 2 == 1) {
    return (n * n) / 2;
  } else {
    int alap = (n * n) / 2 + (n - 2) / 2;
    if (rot == 0) {
      switch (dir) {
      case 0:
        return alap + 1;
      case 1:
        return alap - n;
      case 2:
        return alap;
      case 3:
        return alap - n + 1;
      }
    } else {
      switch (dir) {
      case 2:
        return alap + 1;
      case 3:
        return alap - n;
      case 1:
        return alap;
      case 0:
        return alap - n + 1;
      }
    }
    return -1;
  }
}

int get_new_dir(int rot, int dir) {
  if (rot == 0) {
    switch (dir) {
    case 0:
      return 2;
    case 1:
      return 3;
    case 2:
      return 1;
    case 3:
      return 0;
    default:
      return -1;
    }
  } else {
    switch (dir) {
    case 0:
      return 3;
    case 1:
      return 2;
    case 2:
      return 0;
    case 3:
      return 1;
    default:
      return -1;
    }
  }
}

int get_new_ind(int dir, int ind, int n) {
  switch (dir) {
  case 0:
    return bal(ind);
    break;
  case 1:
    return jobb(ind);
    break;
  case 2:
    return fel(ind, n);
    break;
  case 3:
    return le(ind, n);
    break;
  default:
    return -1;
  }
}
int fel(int ind, int n) { return ind - n; }
int le(int ind, int n) { return ind + n; }
int bal(int ind) { return ind - 1; }
int jobb(int ind) { return ind + 1; }

void print_matrix(int n, int *mat) {
  // mivel 20*20 az 200 ezert max 3 jegyu szamok vannak a matrixban
  if ((n * n) >= 100) {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n; j++) {
        int el = mat[i * n + j];
        if (el >= 100)
          printf("%d ", el);
        else if (el >= 10)
          printf(" %d ", el);
        else
          printf("  %d ", el);
      }
      printf("\n");
    }
  } else if ((n * n) >= 10) {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n; j++) {
        int el = mat[i * n + j];
        if (el >= 10)
          printf("%d ", el);
        else
          printf(" %d ", el);
      }
      printf("\n");
    }
  } else {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n; j++) {
        int el = mat[i * n + j];
        printf("%d ", el);
      }
      printf("\n");
    }
  }
}

char dir_to_str(int dir) {
  switch (dir) {
  case 0:
    return 'l';
  case 1:
    return 'r';
  case 2:
    return 'u';
  case 3:
    return 'd';
  }
  return '0';
}

int save_mat(int n, int *mat, int dir, int rot) {
  if (mat == NULL) {
    printf("No matrix\n");
    return -1;
  }
  char *filename;
  asprintf(&filename, "spiral_%d_%c_%s.txt", n, dir_to_str(dir),
           rot == 0 ? "cw" : "ccw");
  FILE *f = fopen(filename, "w");
  if (f == NULL) {
    printf("No file");
    return -1;
  }
  for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++) {
      int el = mat[i * n + j];
      fprintf(f, "%d\t", el);
    }
    fprintf(f, "\n");
  }
  fclose(f);
  return 0;
}

int *load_mat(int *mat, int n, FILE *f) {
  mat = alloc_matrix(n, mat);
  for (int i = 0; i < n * n; i++) {
    fscanf(f, "%d", mat + i);
  }
  fclose(f);
  return mat;
}
