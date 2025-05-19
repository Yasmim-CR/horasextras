Console.Clear();

int horasTrabalhadas, horasExtras;
decimal valorSalario;

Console.WriteLine("Olá trabalhador, vamos calcular seu salário!");
Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();

Console.Write("Digite o valor do salário: R$ ");
valorSalario = Convert.ToDecimal(Console.ReadLine()!);

Console.Write("Digite as horas trabalhadas: ");
horasTrabalhadas = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Digite as horas extras trabalhadas: ");
horasExtras = Convert.ToInt32(Console.ReadLine()!);


Console.WriteLine($"O salário total é: {CalculaSalario():C2}");

decimal CalculaSalario()
{
    decimal salario = valorSalario * horasTrabalhadas;
    decimal salarioTotal = salario + (horasExtras * 1.4m);
    return salarioTotal;
}