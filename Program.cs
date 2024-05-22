using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iph = new Iphone("(15)99999-9999","Iphone 15","26354646543243",512);
iph.Ligar();
iph.InstalarAplicativo("Instagram");
iph.ReceberLigacao();
Console.WriteLine("");
Nokia nk =new Nokia("(15)99999-9999","Nokia G60 5G","1658768542316845314",512);
nk.Ligar();
nk.InstalarAplicativo("Shopee");
nk.ReceberLigacao();