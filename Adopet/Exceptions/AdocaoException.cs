namespace Adopet.Exceptions;

public class AdocaoException : Exception
{
    public AdocaoException(string? mensagem) : base(mensagem) { }

    public AdocaoException(string? mensagem, Exception? excecaoInterna)
        : base(mensagem, excecaoInterna) { }
}
