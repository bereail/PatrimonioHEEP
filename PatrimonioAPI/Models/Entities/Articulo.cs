﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PatrimonioAPI.Models;

public partial class Articulo
{
    public int Id { get; set; }

    public string Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public virtual ICollection<Component> Components { get; set; } = new List<Component>();
}