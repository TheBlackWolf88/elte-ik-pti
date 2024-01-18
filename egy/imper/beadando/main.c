#include "menu.h"
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>

int main() {

  int *mat = NULL;
  int c = -1;
  int n = 0;
  int dir = 0;
  int rot = 0;
  int res;
  while (print_menu(), res = scanf("%d", &c), c != 5) {
    if (c <= -1 || c > 5 || res < 1) {
      int ch;
      while ((ch = getchar()) != '\n' && ch != EOF);
      continue;
    }
    mat = choose(&n, c, mat, &dir, &rot);
  }
  free(mat);
  return 0;
}
