using Semana08_Classes.Modelo;

Cliente cliente = new Cliente("João da Silva", "123.456.789-00");

Console.WriteLine($"Nome: {cliente.Nome}");
Console.WriteLine($"CPF: {cliente.Cpf}");

Console.ReadKey();