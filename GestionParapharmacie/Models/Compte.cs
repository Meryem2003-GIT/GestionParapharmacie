using System;
using System.Collections.Generic;

namespace GestionParapharmacie.Models;

public partial class Compte
{
    public string Cin { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public DateOnly? DateNaissance { get; set; }

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Pharmacien> Pharmaciens { get; set; } = new List<Pharmacien>();
}
