void Pifagor(double x1, double y1, double z1, 
double x2, double y2, double z2)
{
    double gipotenuza = Math.Sqrt
    ((x2 - x1) * (x2 - x1) + (y2 - y1) 
    * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.Write("Answer is: " + gipotenuza);
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Pifagor(x1, y1, z1, x2, y2, z2);