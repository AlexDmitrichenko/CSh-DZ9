// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии. 
// N = 5 -> "5, 4, 3, 2, 1"      N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.Write("Введите число N: "); 
// int N  = int.Parse(Console.ReadLine()!);  
// Console.WriteLine(PrintNumbers(N,1));
// Method---------------------------------
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start - 1, end));
// }
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.   M = 1; N = 15 -> 120    M = 4; N = 8. -> 30
// Console.Write("Введите число M: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SumNumbers(M, N));
// Method---------------------------------
// int SumNumbers(int M, int N)
// {
//             if (M == N) return M;                       
//             else if (M < N) return (N + SumNumbers(M, N - 1)); 
//             else return (N + SumNumbers(M, N + 1));            
// }
// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9     m = 3, n = 2 -> A(m,n) = 29
// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Function(m, n)); 
// Method---------------------------------
// int Function(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else
//       if ((m != 0) && (n == 0))
//         return Function(m - 1, 1);
//     else
//         return Function(m - 1, Function(m, n - 1));
// }

