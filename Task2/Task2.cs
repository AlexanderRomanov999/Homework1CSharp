Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
if (numA > numB) {
    Console.WriteLine($"max = {numA}");
}
if (numA < numB) {
    Console.WriteLine($"max = {numB}");
}
else {
    Console.WriteLine($"оба числа равны {numA}");
}