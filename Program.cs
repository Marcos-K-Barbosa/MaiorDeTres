int NUMERO1, NUMERO2, NUMERO3;

Console.Clear();



Console.WriteLine("---- MAIOR DE TRÊS----");

Console.WriteLine("Digite Três numero e eu irei dizer qual é o maior. .");

Console.Write(" digite o primeiro numero (Inteiro): ");

NUMERO1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite outro numero (Inteiro): ");

NUMERO3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite outro numero (Inteiro): ");

NUMERO2 = Convert.ToInt32(Console.ReadLine());

if (NUMERO1 >= NUMERO2 && NUMERO1 >= NUMERO3)
{
    Console.WriteLine($"o maior numero entre esses é: {NUMERO1}");


}

else if (NUMERO2 >= NUMERO1 && NUMERO2 >= NUMERO3)
{
    Console.WriteLine($"o maior numero entre esses é: {NUMERO2}");


}
else if (NUMERO3 >= NUMERO1 && NUMERO3 >= NUMERO2)
{
    Console.WriteLine($"o maior numero entre esses é: {NUMERO3}");


}