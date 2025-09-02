// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Luva!");

Televisao tv = new Televisao(55f);
Console.WriteLine($"A TV tem o tamanho {tv.Tamanho}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");