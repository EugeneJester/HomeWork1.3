//Задача 29: https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=699
Console.Clear();
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(150, 181); // [150, 180]

Console.WriteLine($"[{string.Join(", ", array)}]");
int myRost = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] >= myRost)
    count++; // count = count + 1;
}
Console.WriteLine(count);
