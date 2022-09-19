abstract class Decorator : Mensagem{
    protected Mensagem mensagem;

    public Decorator(Mensagem mensagem)
    {
        this.mensagem = mensagem;
    }

    public override string notificacao()
    {
        if (this.mensagem != null)
        {
            return this.mensagem.notificacao();
        }
        else
        {
            return string.Empty;
        }
    }
}