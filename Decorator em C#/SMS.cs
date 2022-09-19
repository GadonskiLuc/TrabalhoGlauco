class SMS : Decorator{
    public SMS (Mensagem mensagem) : base(mensagem){
    }

    public override string notificacao(){
        return $"SMS: {base.notificacao()}";
    }
}