using CustomerRegistration;

ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");

Console.WriteLine($"Bem-vindo, cliente VIP: {cliente1.Nome}");
Console.WriteLine($"Idade: {cliente1.Idade}");
Console.WriteLine($"Nível de Fidelidade: {cliente1.Fidelidade}");
Console.WriteLine($"Código VIP: {cliente1.CodigoVIP}\n");

Console.WriteLine($"Bem-vindo, cliente VIP: {cliente2.Nome}");
Console.WriteLine($"Idade: {cliente2.Idade}");
Console.WriteLine($"Nível de Fidelidade: {cliente2.Fidelidade}");
Console.WriteLine($"Código VIP: {cliente2.CodigoVIP}\n");