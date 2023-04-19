Console.Clear();

double altura;
string sexo;


Console.WriteLine("\n--- Saiba o peso ideal ---");

Console.WriteLine("Coloque \"M\" para o sexo: Mascolino");
Console.WriteLine("Coloque \"F\" para o sexo: Feminino");
sexo = Console.ReadLine()!.ToUpper();


bool sexo1 = sexo == "F";
bool sexo2 = sexo == "M";

if (sexo1)
{
    Console.Write("\nColoque a sua Altura1...: ");
    altura = Double.Parse(Console.ReadLine()!);

    double pesoF = (altura * 62.1) - 44.7;
    Console.WriteLine($"Seu peso ideal é {pesoF:N}Kg."); 
}
else if (sexo2)
{
    Console.Write("\nColoque a sua Altura2...: ");
    altura = Double.Parse(Console.ReadLine()!);
    double pesoF = (altura * 72.7) - 58.0;
    Console.WriteLine($"Seu peso ideal é {pesoF:N}Kg.");
}

else 
{
    Console.WriteLine("Opção invalida");
}