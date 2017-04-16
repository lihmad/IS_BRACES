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

    // Doprava
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class Doprava
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public string Type { get; set; } // Type (length: 250)

        // Reverse navigation

        /// <summary>
        /// Child Zajezdy where [Zajezdy].[ID_Doprava] point to this entity (FK_Zajezdy_Doprava)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Zajezdy> Zajezdy { get; set; } // Zajezdy.FK_Zajezdy_Doprava

        public Doprava()
        {
            Id = System.Guid.NewGuid();
            Zajezdy = new System.Collections.Generic.List<Zajezdy>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
