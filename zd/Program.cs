Console.WriteLine("Выберите задание:");
Console.WriteLine("Задача 1. Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.");
Console.WriteLine("Задание 2. Возвращает индекс этого элемента или же указание, что такого элемента нет");
Console.WriteLine("Задание 3. Найдите среднее арифметическое элементов в каждом столбце. ");
int k = Convert.ToInt32(Console.ReadLine());
switch (k)
{
    case 1:
      Task1();
      break;
    case 2:
    Task2();
    break;
    case 3:
    Task3();
    break;
   
      default:
      break;
}
void Task1()
{
//   Задача 47. Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.


Console.WriteLine("Введите размер массива М и N");
 int m=Convert.ToInt32(Console.ReadLine());
 int n=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("заполните массив переменными");
 
 float [,]array2d= new float[m,n];

  for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    
       array2d[i,j] = Convert.ToSingle(Console.ReadLine());
    
    }
 }

Console.WriteLine("Массив который получили");

 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    
    Console.Write((array2d[i,j]) + "        ");

    }
    Console.WriteLine();
 }

}


void Task2()
{
  

Console.WriteLine("Введите М и N");
 int m=Convert.ToInt32(Console.ReadLine());
 int n=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число которое надо проверить (от 1 до 10)");
 int a=Convert.ToInt32(Console.ReadLine());
 
 
 int[,]array2d= new int[m,n];

 Random random = new Random();

 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array2d[i,j]= random.Next(1,11);
    Console.Write(array2d[i,j] + "  ");
    }
    Console.WriteLine();
 }

 for (int i =0; i< m; i++)
 {
   for (int j = 0; j<n; j++)
   {
   if (array2d[i,j]==a) 
   Console.WriteLine($"Такое число есть в позиции {i+1},{j+1}");
   //else
   //Console.WriteLine("Такого числа в массиве нет");

    }
   
 }
int c = 0;
for (int i =0; i< m; i++)
 { 
   for (int j = 0; j<n; j++)
   { 
   if (array2d[i,j]!=a) 
   c ++;
   
    }
   
 }
 if (c==n*m)
 Console.WriteLine($"числа {a} нет в массиве");
}


void Task3()
{
    Console.WriteLine("Введите М и N");
 int m=Convert.ToInt32(Console.ReadLine());
 int n=Convert.ToInt32(Console.ReadLine());
 
 
 int[,]array2d= new int[m,n];
Console.WriteLine("Введите переменные массива");
  for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array2d[i,j]= Convert.ToInt32(Console.ReadLine());
    }
 }
Console.WriteLine("Массив который у нас получился");
 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    Console.Write(array2d[i,j] + "    ");
    }
    Console.WriteLine();
 }


 for (int j =0; j< n; j++)
 {   float sum=0;
    float average = 0;
    for (int i = 0; i<m; i++)
    {
    sum= sum + array2d[i,j];
    }
    average=sum/m;
    Console.WriteLine($"Среднее арифмитическое столбца {j+1} = {average}");
 }

}