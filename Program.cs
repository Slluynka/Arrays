//Завдання1 
/*
int[] arr1 = {2,3,7,8,33,5};
int sum=0;
float avarage;
for (int i = 0; i < arr1.Length; i++)
{
    sum += arr1[i];
}
avarage = sum/arr1.Length;
Console.WriteLine($"Середнє арифметичне всіх елементів : {avarage:F0}");
//Завдання2
int i ;
int[] arr2 = {1, 2, 3,3,4, 2, 1 };
for ( i = 0; i < arr2.Length; i++)
{
    if (arr2[i] != arr2[arr2.Length - i - 1])
    {
        Console.WriteLine("не паліндром");
        break;
    }
}
if (i == arr2.Length)
{
    Console.WriteLine("паліндром");
}

//Завдання3
int i;
int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, };
for (i = 0; i < arr1.Length; i++)
{
    if (arr1[i]%2==0)
    {
        Console.WriteLine(arr1[i]);
    }

}

//Завдання4
int i, sum = 0 ;
int[] arr33 = { 3, 56, 7, 8, -1, 5, -19 };
for (i = 0; i < arr33.Length; i++)
{
    if (arr33[i] > 0)
    { sum = sum + arr33[i];}
}
Console.WriteLine(sum);

//Завдання5
int i;
int[] arr4 = { 4, 6, 7, 9, 1, 6, 1, 1 };
int number = 1;
for (i= 0; i < arr4.Length; i++)
{
    if (arr4[i] == number)
    {
        Console.WriteLine($"Найменший індекс заданого елемента у масиві = {i:F0}");
        break;
    }

}
//Завдання6
using System.Net.Http.Headers;

int product = 1, i;
int[] arr5 = { 3, -5, 6, 2, -3, 8, 9, -5 };
for (i = 0; i < arr5.Length; i++)
{
    if (arr5[i] < 0)
    { product = product * arr5[i]; }
}
Console.WriteLine(product);

//Завдання1 ( Багатовимірні масиви )
int diagonalSum = 0;
int[,] arr111 = new int[3, 3] { { 4, 5, 7 }, { 8, 4, 5 }, { 1, 2, 3 } };
for (int i = 0; i < 3; i++)
{ diagonalSum = diagonalSum + arr111[i, i]; }
Console.WriteLine($"Сума елементів по головній діагоналі = {diagonalSum:F0}");
//Завдання2 ( Багатовимірні масиви )
int a, product = 1;
Console.WriteLine("Введіть номер стовпця < 3 : ");
a = int.Parse(Console.ReadLine());
if (a > 3)
{ Console.WriteLine("Номер стовпця неправильний"); 
  return;
}
int[,] arr222 = new int[3, 3] { { 4, 5, 7 }, { 8, 4, 5 }, { 1, 2, 3 } };
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        if (j == a)
        {
            product = product * arr222[i, j];
        }
Console.WriteLine($"добуток всіх елементів стовпця {a:F0} матриці = {product:F0}");
*/
//Завдання3 ( Багатовимірні масиви )
int[,] arrA = new int[3, 3] { { 4, 5, 7 }, { 8, 4, 5 }, { 1, 2, 3 } };
int[,] arr90 = new int[3,3];

for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        arr90[2-j, i] = arrA[i, j];
foreach (var element in arrA)
{
    Console.Write("{0}\t", element);

}
Console.WriteLine();
foreach (var element in arr90)
{
    Console.Write("{0}\t", element);
}