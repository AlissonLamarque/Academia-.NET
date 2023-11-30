using System;
using System.Collections.Generic;

namespace WF_MiniERP.DataModel;

public partial class Produto
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Valor { get; set; }

    public int? FkFornecedor { get; set; }

    public virtual Fornecedor? FkFornecedorNavigation { get; set; }
}
