﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exception
{
    public class JogoJaCadastradoException : SystemException
    {
        public JogoJaCadastradoException() 
            : base("Este jogo já está cadastrado")
        { }
    }
}
