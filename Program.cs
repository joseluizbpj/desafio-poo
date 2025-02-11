using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Nokia nokia = new Nokia("123", "Nokia modelo", "12345", "32GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("456", "Iphone modelo", "6789", "32GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
 