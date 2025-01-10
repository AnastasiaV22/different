#include <iostream>
#include <vector>
#include <omp.h>

using namespace std;
// Генерация случайной квадратной матрицы размером size x size
vector<vector<int>> generateRandomMatrix(int size) {
    vector<vector<int>> matrix(size, vector<int>(size, 0));

    for (int i = 0; i < size; ++i) {
        for (int j = 0; j < size; ++j) {
            matrix[i][j] = rand() % 10;
        }
    }

    return matrix;
}

// Последовательное перемножение матриц
vector<vector<int>> multiplyMatricesSequential(const vector<vector<int>>& matrixA,
    const vector<vector<int>>& matrixB, int size) {
    vector<vector<int>> result(size, vector<int>(size, 0));

    for (int i = 0; i < size; ++i) {
        for (int j = 0; j < size; ++j) {
            for (int k = 0; k < size; ++k) {
                result[i][j] += matrixA[i][k] * matrixB[k][j];
            }
        }
    }

    return result;
}

// Параллельное перемножение матриц с помощью OpenMP
vector<vector<int>> multiplyMatricesParallel(const vector<vector<int>>& matrixA,
    const vector<vector<int>>& matrixB, int size) {
    vector<vector<int>> result(size, vector<int>(size, 0));

#pragma omp parallel for
    for (int i = 0; i < size; ++i) {
        #pragma omp parallel
        for (int j = 0; j < size; ++j) {
            #pragma omp parallel
            for (int k = 0; k < size; ++k) {
                result[i][j] += matrixA[i][k] * matrixB[k][j];
            }
        }
    }

    return result;
}

#pragma warning(default:4716)
int Choose(const vector<vector<int>>& matrixA,
    const vector<vector<int>>& matrixB) {
    int choose;
 //  cout << "Паралельное-1 \n Последовательное-2 : ";
 //   cin >> choose;

    int size = matrixA.size();

    //if (choose == 1) {
        // Параллельное перемножение
        cout << "Парале.";
        double start_time, end_time;
        start_time = omp_get_wtime();

        vector<vector<int>> resultParallel = multiplyMatricesParallel(matrixA, matrixB, size);
        end_time = omp_get_wtime();

        cout << "время: " << (float)(end_time - start_time)<< "\n";
        
    //}
    //if (choose == 2) {
        // Последовательное перемножение
        cout << "Послед.";
        start_time = omp_get_wtime();
        vector<vector<int>> resultSequential = multiplyMatricesSequential(matrixA, matrixB,size);
        end_time = omp_get_wtime();

        cout << "время: " << (float)(end_time - start_time) << "\n";
       
    //}

    return 0;
}

int main() {
    setlocale(LC_ALL, "Russian");
    int size;
    while (true) {
        cout << "Размер: ";
        cin >> size;

        // Генерация матриц
        vector<vector<int>> matrixA = generateRandomMatrix(size);
        vector<vector<int>> matrixB = generateRandomMatrix(size);
    
    #pragma warning(default:4716)
        Choose(matrixA, matrixB);
    }
    return 0;
}