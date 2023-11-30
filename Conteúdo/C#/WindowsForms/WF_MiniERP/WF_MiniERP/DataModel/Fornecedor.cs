using System;
using System.Collections.Generic;

namespace WF_MiniERP.DataModel;

public partial class Fornecedor
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Cnpj { get; set; }

    public virtual ICollection<Notum> Nota { get; set; } = new List<Notum>();

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
