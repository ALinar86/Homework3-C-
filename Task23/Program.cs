void kub(int N)
{
    for (int i = 1; i <= N; i++ )
    {
            Console.Write(i * i * i  + " ");
    }
}
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
kub(x);