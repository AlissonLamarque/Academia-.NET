﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal abstract class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }

        public abstract void Dirigir();
    }
}
