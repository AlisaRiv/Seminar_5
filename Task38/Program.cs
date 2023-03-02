//Задача 38: Задайте массив вещественных чисел. Найдите разницу между
 //максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Задача 38");
int elementCount = 5;
int[] a = new int[elementCount];
System.Random random = new System.Random();
bool isFirst = true;
int minNumber = 0;
int maxNumber = 0;
Console.Write("[");
for (int i=0; i<elementCount; i++) {
    a[i] = random.Next(0, 100);
    string prefix = isFirst ? "" : ", ";
    if (isFirst) {
        isFirst = false;
        minNumber = a[i];
        maxNumber = a[i];
    }
    Console.Write($"{prefix}{a[i]}");
    if (minNumber > a[i]) {
        minNumber = a[i];
    }
    if (maxNumber < a[i]) {
        maxNumber = a[i];
    }
}
int result = maxNumber - minNumber;
Console.WriteLine("] -> {0}", result);
