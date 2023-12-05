using ParkingLotSys.models;

Console.WriteLine("Informe o preço base do estacionamento:");
string? precoBasestr = Console.ReadLine();
Console.WriteLine("Informe o preço por HORA do estacionamento:");
string? precoHorastr = Console.ReadLine();
double precoBase = Double.Parse(precoBasestr);
double precoHora = Double.Parse(precoHorastr);

Estacionamento estacionamento = new Estacionamento(precoBase, precoHora);
estacionamento.carros = new List<string>();
while (true){
    Console.WriteLine("Selecione a sua próxima ação:\n1 - Adicionar carro\n2 - Remover carro\n3 - Listar carros\n4 - Encerrar programa");
    string? acao = Console.ReadLine();
    if (acao == "1")
    {
        Console.WriteLine("Informe a placa do veículo:\n");
        string? placa = Console.ReadLine();
        estacionamento.AdicionarCarro(placa);
    }
    else if (acao == "2")
    {
        Console.WriteLine("Informe a placa do veículo:\n");
        string? placa = Console.ReadLine();
        estacionamento.RemoverCarro(placa);
    }
    else if (acao == "3")
    {
        estacionamento.ListarCarros();
    }
    else if (acao == "4")
    {
        Console.WriteLine("Finalizando o programa :)");
        break;
    }
}

