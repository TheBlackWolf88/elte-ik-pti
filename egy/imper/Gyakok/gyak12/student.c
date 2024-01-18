#include "student.h"
#include <stdio.h>
#include <stdlib.h>

void printS(MyStud s) {
  char *szint = "---";
  switch (s.szint) {
  case BSc:
    szint = "BSc";
    printf("ID: %d (kor: %d) [%s] - atlag : %.4f\n - kurzusok: %d\n", s.azon,
           s.kor, szint, s.atlag, s.adat.kurzusok);
    break;
  case MSc:
    szint = "MSc";
    printf("ID: %d (kor: %d) [%s] - atlag : %.4f\n - okki: %f\n", s.azon, s.kor,
           szint, s.atlag, s.adat.okki);
    break;
  case PhD:
    szint = "PhD";
    printf("ID: %d (kor: %d) [%s] - atlag : %.4f\n - imp: %.2f erdos: %d\n",
           s.azon, s.kor, szint, s.atlag, s.adat.cikk.imp, s.adat.cikk.erdos);
    break;
  }
  //    printf("ID: %d (kor: %d) - atlag : %.4f\n", s.azon, s.kor, s.atlag );
}

MyStud searchS(MyStud arr[], int n, int (*funcPtr)(MyStud, MyStud)) {
  MyStud winner = arr[0];
  for (int i = 1; i < n; i++) {
    if ((*funcPtr)(winner, arr[i]) < 0) {
      winner = arr[i];
    }
  }
  return winner;
}

MyStud *student_init(int n, enum Type _szint) {
  MyStud *hallgato = malloc(sizeof(MyStud));
  if (hallgato == NULL) {
    printf("Malloc error\n");
    return NULL;
  }
  hallgato->azon = n;
  hallgato->atlag = (float)rand() / (float)(RAND_MAX) * 100.00;
  hallgato->kor = rand() % 7 + 18;
  hallgato->szint = rand() % 3;
  if (hallgato->szint == BSc) {
    hallgato->adat.kurzusok = rand() % 3 + 5;
  } else if (hallgato->szint == MSc) {
    hallgato->adat.okki = (float)rand() / (float)(RAND_MAX) * 5.0;
  } else if (hallgato->szint == PhD) {
    hallgato->adat.cikk.imp = (float)rand() / (float)(RAND_MAX) * 25.0;
    hallgato->adat.cikk.erdos = rand() % 50 + 1;
  }
  return hallgato;
}

int bestS(MyStud h1, MyStud h2) {
  return (h1.atlag > h2.atlag) - (h1.atlag < h2.atlag);
}

int oldestS(MyStud h1, MyStud h2) {
  return (h1.kor > h2.kor) - (h1.kor < h2.kor);
}
MyStud* searchS2(MyStud** arr, int n, int (*funcPtr)(MyStud*, MyStud*)) {
  MyStud* winner = *arr;
  for (int i = 1; i < n; i++) {
    if ((*funcPtr)(winner, *(arr+i)) < 0) {
      winner = *(arr+i);
    }
  }
  return winner;
}


int bestS2(MyStud *h1, MyStud *h2) {
  return (h1->atlag > h2->atlag) - (h1->atlag < h2->atlag);
}

int oldestS2(MyStud *h1, MyStud *h2) {
  return (h1->kor > h2->kor) - (h1->kor < h2->kor);
}
