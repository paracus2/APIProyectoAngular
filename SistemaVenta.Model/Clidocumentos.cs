﻿using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Clidocumentos
{
    public int IdNumeroDocumento { get; set; }

    public int UltimoNumero { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
