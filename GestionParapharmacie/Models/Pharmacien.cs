using System;
using System.Collections.Generic;

namespace GestionParapharmacie.Models;

public partial class Pharmacien
{
    public string? Cin { get; set; }

    public int IdPharmacien { get; set; }

    public string MotPasse { get; set; } = null!;

    public virtual Compte? CinNavigation { get; set; }
}
