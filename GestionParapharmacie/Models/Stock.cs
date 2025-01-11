using System;
using System.Collections.Generic;

namespace GestionParapharmacie.Models;

public partial class Stock
{
    public int IdStock { get; set; }

    public int Reference { get; set; }

    public int Quantite { get; set; }

    public virtual Produit ReferenceNavigation { get; set; } = null!;
}
