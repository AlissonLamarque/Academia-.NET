using System;
using System.Collections.Generic;

namespace WF_MiniERP.DataModel;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Notum> Nota { get; set; } = new List<Notum>();
}
