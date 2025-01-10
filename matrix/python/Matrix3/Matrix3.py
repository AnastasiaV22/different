import numpy as np
import threading
import time

def Choose(matrix_a, matrix_b, size):
    print("choose")
    print("simple-1")            
    print("NumPy-2")          
    print("Threads-3")             
    choose = int(input())

    if choose==1:
        start_time=time.time()
        multiply_matrices_sequential(matrix_a, matrix_b, size)
        end_time=time.time()
        result=str(end_time-start_time)

        print("Simple is contined.")
        print("Time is " + result)
        Choose(matrix_a, matrix_b, size)
    elif choose==2:
        start_time=time.time()
        multiply_matrices_NumPY(matrix_a, matrix_b)
        end_time=time.time()
        result=str(end_time-start_time)

        print("Simple is contined.")
        print("Time is " + result)
        Choose(matrix_a, matrix_b, size)
    elif choose==3:
        start_time=time.time()
        multiply_matrices(matrix_a, matrix_b, size)
        end_time=time.time()
        result=str(end_time-start_time)

        print("Simple is contined.")
        print("Time is " + result)
        Choose(matrix_a, matrix_b, size)
    else: return

# 
def generate_random_matrix(size):
    return np.random.randint(1, 10, size=(size, size))

# simple
def multiply_matrices_sequential(matrix_a, matrix_b, size):
    result = np.zeros((size, size))
    for i in range(size):
        for j in range(size):
            for k in range(size):
                result[i, j] += matrix_a[i, k] * matrix_b[k, j];
    return result

# NumPY 
def multiply_matrices_NumPY(matrix_a, matrix_b):
    result = np.dot(matrix_a, matrix_b)
    return result


# Threads 
def multiply_matrix(matrix_a, matrix_b, result, row_index):
    for j in range(len(matrix_b[0])):
        total = 0
        for k in range(len(matrix_b)):
            total += matrix_a[row_index][k] * matrix_b[k][j]
        result[row_index][j] = total

def multiply_matrices(matrix_a, matrix_b, size):
    num_threads = size
    result = [[0] * len(matrix_b[0]) for _ in range(len(matrix_a))]

    threads = []
    for i in range(num_threads):
        thread = threading.Thread(target=multiply_matrix, args=(matrix_a, matrix_b, result, i))
        thread.start()
        threads.append(thread)

    for thread in threads:
        thread.join()
    return result

def main():
    size = int(input("size is: "))

    matrix_a = generate_random_matrix(size)
    matrix_b = generate_random_matrix(size)

    Choose(matrix_a, matrix_b, size)

main();