using System;
using System.Collections.Generic;

namespace TestandoASPNETMVC;

public partial class Fornecedor
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Cnpj { get; set; }

    public virtual ICollection<Produto> Produtos { get; } = new List<Produto>();
}
