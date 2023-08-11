using System;

public class PessoaException : Exception
{
	public PessoaException()
	{
	}
    public PessoaException(string message)
        : base(message)
    {
    }
}

