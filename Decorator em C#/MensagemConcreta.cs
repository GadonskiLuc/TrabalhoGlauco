class MensagemConcreta : Mensagem{

    protected string mensagem;

    public MensagemConcreta(){
        this.mensagem="";
    }
    public void setMensagem(string msg)
    {
        this.mensagem = msg;
    }
    public override string notificacao(){
        return this.mensagem;
    }
}