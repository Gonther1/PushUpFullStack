﻿using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class Categorium : BaseEntity
{
    

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
