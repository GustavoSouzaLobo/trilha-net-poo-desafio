using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "123212321", Modelo: "Modelo 1", IMEI: "1111111111", Memoria: 64);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("LinkedIn");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "222222333333", Modelo: "Modelo 2", IMEI: "222222222222", Memoria: 128);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");