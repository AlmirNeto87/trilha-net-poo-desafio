using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("12345", "iPhone 14", "IMEI123456", 128);
Nokia nokia = new Nokia("98745635", "Nokia 3310", "IMEI12456", 64);

nokia.Ligar();
iphone.Ligar();

nokia.ReceberLigacao();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Vivo");
iphone.InstalarAplicativo("ICloud");