//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
 //чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Clear();
Console.WriteLine("Задача 34");
int[] a = new int[6];
System.Random random = new System.Random();
bool isFirst = true;
int counter = 0;
for (int i=0; i<6; i++) {
    a[i] = random.Next(100, 1000);
    string prefix = isFirst ? "" : ", ";
    if (isFirst) { isFirst = false; }
    Console.Write($"{prefix}{a[i]}");
    if (a[i]%2 == 0) {
        counter++;
    }
}
Console.WriteLine(" -> {0}", counter);
