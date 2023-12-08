using System;
using System.Collections.Generic;

namespace _13_MiniERPcomEntity.DataModel;

public partial class Notum
{
    public int Id { get; set; }

    public int? FkProduto { get; set; }

    public int? FkCliente { get; set; }

    public virtual Cliente? FkClienteNavigation { get; set; }

    public virtual Produto? FkProdutoNavigation { get; set; }
}
