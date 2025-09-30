using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone("12345", "iPhone 14", "IMEI123456", 128);
Smartphone nokia = new Nokia("98745635", "Nokia 3310", "IMEI12456", 64);

nokia.Ligar();
iphone.Ligar();

nokia.ReceberLigacao();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Vivo");
iphone.InstalarAplicativo("ICloud");


nokia.ListarAplicativos();
iphone.ListarAplicativos();

nokia.DeletarAplicativo("oi");
iphone.DeletarAplicativo("Play Store");

nokia.DeletarAplicativo("Vivo");
iphone.DeletarAplicativo("ICloud");

nokia.ExibirInformacoes();
iphone.ExibirInformacoes();