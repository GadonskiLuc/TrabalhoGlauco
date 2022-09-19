class Whatsapp : Decorator{
    public Whatsapp (Mensagem mensagem) : base(mensagem){
    }

    public override string notificacao(){
        return $"Whatsapp: {base.notificacao()}";
    }
}