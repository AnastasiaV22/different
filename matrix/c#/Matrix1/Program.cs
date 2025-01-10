using System;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
class MatrixMultiplication
{
    static void Main()
    {
        
        
        //Console.Write("Парал. - 1 Послед. - 2: ");
        while (true)
            Choose();
    }
    static void Choose()
    {
        Console.Write("Размер матриц: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[,] matrixA = GenerateRandomMatrix(size);
        int[,] matrixB = GenerateRandomMatrix(size);

        //int choose = Convert.ToInt32(Console.ReadLine());

       // if (choose == 1)
        {
            Console.WriteLine("паралел.");
            // Параллельное перемножение
            Stopwatch stopwatchpar = new Stopwatch();
            stopwatchpar.Start();

            int[,] resultParallel = MultiplyMatricesParallel(matrixA, matrixB, size);

            stopwatchpar.Stop();
            Console.WriteLine($"Время: {stopwatchpar.ElapsedMilliseconds} миллисекунд");

        }
        // if (choose == 2)
        {
            Console.WriteLine("после.");
            // Последовательное перемножение
            Stopwatch stopwatchpar = new Stopwatch();
            stopwatchpar.Start();

            int[,] resultSequential = MultiplyMatricesSequential(matrixA, matrixB, size);

            stopwatchpar.Stop();
            Console.WriteLine($"Время: {stopwatchpar.ElapsedMilliseconds} миллисекунд");

        }
       //else return;
    }
    static int[,] GenerateRandomMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }

    static int[,] MultiplyMatricesSequential(int[,] matrixA, int[,] matrixB, int size)
    {
        int[,] result = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    static int[,] MultiplyMatricesParallel(int[,] matrixA, int[,] matrixB, int size)
    {
        int[,] result = new int[size, size];
        object lockObject = new object();

        int taskCount = Environment.ProcessorCount;

        Task[] tasks = new Task[taskCount];

        for (int t = 0; t < taskCount; t++)
        {
            int startRow = t * size / taskCount;
            int endRow = (t + 1) * size / taskCount;

            tasks[t] = Task.Factory.StartNew((object state) =>
            {
                Tuple<int, int> range = (Tuple<int, int>)state;

                for (int i = range.Item1; i < range.Item2; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < size; k++)
                        {
                            sum += matrixA[i, k] * matrixB[k, j];
                        }

                        lock (lockObject)
                        {
                            result[i, j] += sum;
                        }
                    }
                }
            }, Tuple.Create(startRow, endRow));
        }

        Task.WaitAll(tasks);

        return result;
    }

}