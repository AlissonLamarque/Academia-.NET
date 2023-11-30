using System;
using System.Collections.Generic;

namespace WF_MiniERP.DataModel;

public partial class Notum
{
    public int Id { get; set; }

    public int? FkFornecedor { get; set; }

    public int? FkCliente { get; set; }

    public virtual Cliente? FkClienteNavigation { get; set; }

    public virtual Fornecedor? FkFornecedorNavigation { get; set; }
}
