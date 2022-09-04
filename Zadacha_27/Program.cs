
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(num);

Console.WriteLine("Сумма цифр в числе равна: " + GetSum(result));


int GetSum(string result)
{

int count = 0;

int sum = 0;

while (count < result.Length)
{  
    sum +=  (int) char.GetNumericValue(result[count]);
   
    count++;  
}
 return sum;

}