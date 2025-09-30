// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Console.WriteLine("-- Cartao de Débito --");

CartaoDebito cartaoDebito = new CartaoDebito();
cartaoDebito.Debitar(100);