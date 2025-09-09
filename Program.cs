// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(55f);
Console.WriteLine($"A TV tem o tamanho {tv.Tamanho} polegadas");

tv.Ligar();

tv.IrParaCanal(100);
Console.WriteLine($"Canal atual: {tv.Canal}");

tv.ProximoCanal();
Console.WriteLine($"Canal atual: {tv.Canal}");

tv.CanalAnterior();
Console.WriteLine($"Canal atual: {tv.Canal}");

tv.IrParaCanal(600);

tv.AumentarVolume();
Console.WriteLine($"Volume: {tv.Volume}");

tv.AtivarMudo();
tv.DesativarMudo();

tv.Desligar();
