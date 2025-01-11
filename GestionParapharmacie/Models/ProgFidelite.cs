using System;
using System.Collections.Generic;

namespace GestionParapharmacie.Models;

public partial class ProgFidelite
{
    public int Id { get; set; }

    public int? Points { get; set; }

    public int IdClient { get; set; }

    public double? Remise { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;
}
