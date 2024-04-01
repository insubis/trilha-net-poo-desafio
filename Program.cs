using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456789");
        Iphone iphone = new Iphone("987654321");

        nokia.Ligar();
        iphone.Ligar();

        nokia.ReceberLigacao();
        iphone.ReceberLigacao();

        nokia.InstalarAplicativo("WhatsApp");
        iphone.InstalarAplicativo("Facebook");
    }
    