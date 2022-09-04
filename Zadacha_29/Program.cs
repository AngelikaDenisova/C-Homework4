// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int [] array = new int[8];
int size = array.Length;


for (int i = 0; i < size; i++)
{
   array[i] = new Random().Next(0,101);
}
 
Console.WriteLine ("["+ String.Join(";", array) + "]");
