// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран
// выводя индексы соответствующего элемента

Console.WriteLine($"Задайте (X)");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте (Y)");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте (Z)");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] array3D = new int[x, y, z];
FillArr(array3D);
Console.WriteLine($"Массив с повторяющимися двузначными числами");
PrintArr(array3D);
CreateArray(array3D);
Console.WriteLine($"Массив с не повторяющимися двузначными числами");
PrintArr(array3D);

void CreateArray(int[,,] array3D) {
    int [] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for(int i = 0; i<array.GetLength(0); i++) {
        array [i] = new Random().Next(10,100);
        if(i>0) {
            for(int j=0; j<i; j++) {
                if(array[i]==array[j]) {
                    array[i] = new Random().Next(10,100);
                }
            }
        }
    }
    int temp = 0;
    for(int i=0; i<array3D.GetLength(0); i++) {
        for(int j=0; j<array3D.GetLength(1); j++) {
            for(int k=0; k<array3D.GetLength(2); k++) {
                array3D [i,j,k] = array[temp];
                temp++;
            }
        }
    }

}

void FillArr(int [,,] array3D) {
    for(int i=0; i<array3D.GetLength(0); i++) {
        for(int j=0; j<array3D.GetLength(1); j++) {
            for(int k=0; k<array3D.GetLength(2); k++) {
                array3D [i,j,k] = new Random().Next(10,100);
            }
        }
    }

}

void PrintArr (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}