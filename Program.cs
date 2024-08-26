using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Teste com Nokia
        Smartphone nokia = new Nokia("122156659", "Nokia Modelo", "121212121212", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        // Teste com Iphone
        Smartphone iphone = new Iphone("99885540", "iPhone Modelo", "202020202020", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}