﻿using System;
using System.Collections.Generic;

namespace ESII2025d2.Models;

public partial class Utilizador
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public string email { get; set; } = null!;

    public string username { get; set; } = null!;

    public string palavra_passe { get; set; } = null!;

    public DateOnly datanascimento { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Talento> Talentos { get; set; } = new List<Talento>();
}
