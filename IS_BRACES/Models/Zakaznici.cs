// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace IS_BRACES.Models
{

    // Zakaznici
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class Zakaznici
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public string Jmeno { get; set; } // Jmeno (length: 255)
        public string Prijmeni { get; set; } // Prijmeni (length: 255)
        public System.Guid? IdBydliste { get; set; } // ID_Bydliste
        public System.Guid? IdKontaktniUdaje { get; set; } // ID_Kontaktni_udaje

        // Reverse navigation

        /// <summary>
        /// Child Rezervace where [Rezervace].[ID_Zakaznika] point to this entity (FK_Rezervace_Zakaznici)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Rezervace> Rezervace { get; set; } // Rezervace.FK_Rezervace_Zakaznici
        /// <summary>
        /// Child VazTZakaznikZajezd where [VazT_Zakaznik_Zajezd].[ID_Zakaznik] point to this entity (FK_VazT_Zakaznik_Zajezd_Zakaznici)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VazTZakaznikZajezd> VazTZakaznikZajezd { get; set; } // VazT_Zakaznik_Zajezd.FK_VazT_Zakaznik_Zajezd_Zakaznici

        // Foreign keys

        /// <summary>
        /// Parent Adresa pointed by [Zakaznici].([IdBydliste]) (FK_Zakaznici_Adresa)
        /// </summary>
        public virtual Adresa Adresa { get; set; } // FK_Zakaznici_Adresa
        /// <summary>
        /// Parent KontaktniUdaje pointed by [Zakaznici].([IdKontaktniUdaje]) (FK_Zakaznici_Kontaktni_udaje)
        /// </summary>
        public virtual KontaktniUdaje KontaktniUdaje { get; set; } // FK_Zakaznici_Kontaktni_udaje

        public Zakaznici()
        {
            Id = System.Guid.NewGuid();
            Rezervace = new System.Collections.Generic.List<Rezervace>();
            VazTZakaznikZajezd = new System.Collections.Generic.List<VazTZakaznikZajezd>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
