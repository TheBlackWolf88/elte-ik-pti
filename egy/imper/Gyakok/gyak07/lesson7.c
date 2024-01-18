#include <stdio.h>
#include <ctype.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>

#define BUFFER_D 5
#define BUFFER_X 20
#define N 3
#define M 6
#define SZAM 10

void m_table(int matrix[N][M]){
    for(int i = 0; i < N; i++){
        for (int j = 0; j < M; j++){
            matrix[i][j] = (i+1)*(j+1);
        }
    }
}

void print_arr(int arr[], size_t n){
    for(int i = 0; i < n; i++){
        printf("%d ", arr[i]);
    }
    printf("\n");
}

void print_matrix(int matrix[N][M]){
     for(int i = 0; i < N; i++){
        for (int j = 0; j < M; j++){
            printf("%d ", matrix[i][j]);
        }
        printf("\n");
     }    
}

int hex2dec(char hex[], size_t n){
    int dec = 0;
    for(size_t i = 0; i< n; i++){
        if (isdigit( hex[i])){
            dec += (hex[i]-'0')*pow(16, n-i-1);
        }
        else if ('a' <= hex[i] && hex[i] <= 'f'){
            dec += (hex[i]-'a'+10)*pow(16, n-i-1);
        }
        else if ('A' <= hex[i] && hex[i] <= 'F'){
            dec += (hex[i]-'A'+10)*pow(16, n-i-1);
        }
    }
    return dec;
}

void elso_ketto(){
    int nums[BUFFER_D];
    char hex[BUFFER_X];
    printf("Input: \n");
    char c;
    size_t i = 0; //hex index
    size_t j = 0; //nums index
    while( (c = getchar()) != EOF && j < BUFFER_D ){
        if( isxdigit(c) ){
            //ez i-re rakja es utana noveli
            //wtf
            hex[i++] = c;
        } else if (isspace (c)){
            nums[j++] = hex2dec(hex,i);
            i = 0;
        } else {
            printf("Ignored: %c", c);
        }
    }
    print_arr(nums, j);
    int matrix[N][M];
    m_table(matrix);
    print_matrix(matrix);   

}

void elso_n_sum(){
    int sum = 0;
    int n;
    scanf("%d", &n);
    for(int i = 1; i <= n; i++){
        sum += i;
    }
    printf("sum of the first %d number: %d\n", n, sum);
}

void elso_n_hatvany() {
    int n;
    scanf("%d", &n);
    for(int i = 0; i <= n; i++){
        printf("%d hatvany: %.f\n",i, pow(SZAM, i) );
    }
}

void toltsd_random(int arr[], size_t n) {
    for(int i = 0; i < n; i++){
        arr[i] = rand() % 100;
    }
}

int main(){
        int arr[BUFFER_X];
        srand(time(NULL));
        size_t len_arr = sizeof(arr)/sizeof(arr[0]);
        toltsd_random(arr, len_arr);
        int cNagy50 = 0;
        for(int i = 0; i < len_arr; i++){
            if(arr[i] > 50) cNagy50++;
        }
        printf("cNagy50: %d\n", cNagy50);
        return 0;
}
