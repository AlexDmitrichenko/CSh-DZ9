//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии. 
//N = 5 -> "5, 4, 3, 2, 1"      N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*Console.Write("Введите число N: "); 
int N  = int.Parse(Console.ReadLine()!);  
Console.WriteLine(PrintNumbers(N,1));
// Method---------------------------------
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.   M = 1; N = 15 -> 120    M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine(SunNumbers(M, N));
// Method---------------------------------
int SunNumbers(int M, int N)
// {
//     if(M == N) return M+N;
//     if(M < N) return (N + M) * (N - M + 1)/2;
//     return (M + N) * (M - N + 1)/2;
// }
{
    if(M == N) return M+N;
    if(M < N) return (M + SunNumbers(N, M));
    return (N + SunNumbers(M, N));
}