﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone: ");
Smartphone nokia = new Nokia(numero: "4987", modelo: "Modelo 2", imei: "222222", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
