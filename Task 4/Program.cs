
//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.WriteLine($"Задайте количество строк (n)");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++) {
    for (int c = 0; c <= (n - i); c++) {
        Console.Write(" "); 
    }
    for (int c = 0; c <= i; c++) {
        Console.Write(" "); 
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
    }
    Console.WriteLine();
    Console.WriteLine(); 
}
Console.ReadLine();

static float factorial(int n) {
    float i, x = 1;
    for (i = 1; i <= n; i++) {
        x *= i;
    }    
    return x;
}
