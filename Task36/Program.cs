//Задача 36: Задайте одномерный массив, заполненный случайными числами.
 //Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine("Задача 36");
int[] a = new int[4];
System.Random random = new System.Random();
bool isFirst = true;
int sum = 0;
for (int i=0; i<4; i++) {
    a[i] = random.Next(-100, 100);
    string prefix = isFirst ? "" : ", ";
    if (isFirst) { isFirst = false; }
    Console.Write($"{prefix}{a[i]}");
    if (i%2 == 0) {
        sum+=a[i];
    }
}
Console.WriteLine(" -> {0}", sum);