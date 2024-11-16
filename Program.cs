using DesafioPOO.Models;


Console.WriteLine("Nokia:");
Nokia nokia = new Nokia("12999999999", "Tijolinho", "111111", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Zuma");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Iphone iphone = new Iphone("12998888888","16","222222",64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Subway Surfers");