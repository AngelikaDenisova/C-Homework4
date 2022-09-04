// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    Console.WriteLine("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Число A в степени B равно "+ GetPow(A,B));

    int GetPow (int A, int B)   
    {
    int result = Convert.ToInt32(Math.Pow(A, B));
    return result;
    }
