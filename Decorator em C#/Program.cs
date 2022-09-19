class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        var mensagem = new MensagemConcreta();
        mensagem.setMensagem("Bolsolula 2022");

        //situação 1
        Console.WriteLine("Notificacao sem Decorator: ");
        client.enviar(mensagem);
        Console.WriteLine();
        //situação 2
        Whatsapp whatsapp = new Whatsapp(mensagem);
        Console.WriteLine("Notificacao de Whatsapp");
        client.enviar(whatsapp);
        Console.WriteLine();
        //situação 3
        SMS sms = new SMS(mensagem);
        Console.WriteLine("Notificacao de SMS");
        client.enviar(sms);

        Console.ReadKey();
    }
}