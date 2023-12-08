using System;
using System.Collections.Generic;

namespace TestandoASPNETMVC.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Cliente> clientes { get; } = new List<Cliente>();
}
