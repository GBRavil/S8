// В двумерном массиве целых чисел. Удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.

Console.WriteLine($"Задайте количество строк (м)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте количество столбцов (n)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] nums = new int [m, n];
int row = 0;
int col = 0;
FillArr(nums);
PrintArr(nums);
int min = nums[0,0];
MinNum(nums,row,col);
int [,] newnums = new int [nums.GetLength(0)-1,nums.GetLength(1)-1];

for(int i = 0; i<nums.GetLength(0); i++){
    for(int j = 0; j<nums.GetLength(1); j++){
        if (i < row && j < col) {
            newnums [i, j] = nums [i, j];
        } else if (i > row && j > col) {
            newnums [i-1, j-1] = nums [i,j];
        } else if (i < row && j > col) {
            newnums [i, j-1] = nums [i,j];  
        } else if (i > row && j < col) {
            newnums [i-1, j] = nums [i, j];
        }    
    }
}
PrintArr(newnums);

void MinNum (int [,] n, int r, int c){
    for(int i = 0; i<nums.GetLength(0); i++){
    for(int j = 0; j<nums.GetLength(1); j++){
        if(min>nums[i,j]){
            min=nums[i,j];
            row = i;
            col = j;
        }
    }
}
Console.WriteLine($"Наименьший элемент "+min);
Console.WriteLine($"Индекс["+row+","+col+"]");
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
