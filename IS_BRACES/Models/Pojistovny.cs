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

    // Pojistovny
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class Pojistovny
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public string Nazev { get; set; } // Nazev (length: 255)
        public string Kod { get; set; } // Kod (length: 4)

        // Reverse navigation

        /// <summary>
        /// Child Pojisteni where [Pojisteni].[ID_Pojistovna] point to this entity (FK_Pojisteni_Pojistovny)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Pojisteni> Pojisteni { get; set; } // Pojisteni.FK_Pojisteni_Pojistovny

        public Pojistovny()
        {
            Id = System.Guid.NewGuid();
            Pojisteni = new System.Collections.Generic.List<Pojisteni>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
