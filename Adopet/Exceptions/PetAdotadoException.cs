namespace Adopet.Exceptions;

public class PetAdotadoException : AdocaoException
{
    public PetAdotadoException(string? mensagem) : base(mensagem) {}
    public PetAdotadoException(string? mensagem, Exception? excecaoInterna)
        : base(mensagem, excecaoInterna) { }
}