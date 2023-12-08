using System;
using System.Collections.Generic;

namespace _13_MiniERPcomEntity.DataModel;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Notum> Nota { get; } = new List<Notum>();
}
