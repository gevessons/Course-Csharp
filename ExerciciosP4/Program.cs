using System.Globalization;

int numFun = int.Parse(Console.ReadLine());
double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salario = horas * valorH;

Console.WriteLine("NUMBER = {0} \nSALARY = U$ {1}", numFun, salario.ToString("F2", CultureInfo.InvariantCulture));