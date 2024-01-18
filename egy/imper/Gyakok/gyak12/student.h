#ifndef STUDENT_H
#define STUDENT_H

enum Type {
    BSc,
    MSc,
    PhD
};

typedef struct {
    union Data {
        int kurzusok;
        double okki;
        struct Cikkek {
            double imp;
            unsigned int erdos;
        } cikk;

    } adat;

    double atlag;
    int azon;
    short int kor;
    enum Type szint;

} MyStud;

void printS (MyStud s);

MyStud searchS( MyStud arr[], int n, int(*funcPtr)(MyStud, MyStud));

int bestS ( MyStud h1, MyStud h2);

int oldestS (MyStud h1, MyStud h2);

MyStud* student_init(int n, enum Type _szint );

MyStud* searchS2( MyStud** arr, int n, int(*funcPtr)(MyStud*, MyStud*));

int bestS2 ( MyStud* h1, MyStud* h2);

int oldestS2 (MyStud* h1, MyStud* h2);


#endif // !DEBUG
