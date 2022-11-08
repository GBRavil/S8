// Найти произведение двух матриц
int [,] firstMatrix = new int [3,3];
int [,] secondMatrix = new int [3,3];
int [,] result = new int [3,3];
FillArr(firstMatrix);
PrintArr(firstMatrix);
FillArr(secondMatrix);
PrintArr(secondMatrix);

for(int i = 0; i<firstMatrix.GetLength(0); i++) {
    for(int j = 0; j<secondMatrix.GetLength(1); j++) {
        for(int k = 0; k<secondMatrix.GetLength(0); k++) {
            result[i,j] += firstMatrix [i,k] * secondMatrix[k,j];
        }
        Console.Write(result[i,j] + ", ");
    }
    Console.WriteLine();
}

void FillArr (int [,] num) {
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            num [i, j] = new Random().Next(1,10);

        }
    }
}

void PrintArr(int [,] num) {
    for(int i =0; i<num.GetLength(0); i++) {
        for(int j =0; j<num.GetLength(1); j++) {
            Console.Write($"{num [i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}