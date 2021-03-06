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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class FakeDB_Model : IDB_Model
    {
        public System.Data.Entity.DbSet<Adresa> Adresa { get; set; }
        public System.Data.Entity.DbSet<Destinace> Destinace { get; set; }
        public System.Data.Entity.DbSet<Doprava> Doprava { get; set; }
        public System.Data.Entity.DbSet<Kategorie> Kategorie { get; set; }
        public System.Data.Entity.DbSet<KontaktniUdaje> KontaktniUdaje { get; set; }
        public System.Data.Entity.DbSet<Pojisteni> Pojisteni { get; set; }
        public System.Data.Entity.DbSet<Pojistovny> Pojistovny { get; set; }
        public System.Data.Entity.DbSet<Pokoje> Pokoje { get; set; }
        public System.Data.Entity.DbSet<Prilohy> Prilohy { get; set; }
        public System.Data.Entity.DbSet<Rezervace> Rezervace { get; set; }
        public System.Data.Entity.DbSet<Stravovani> Stravovani { get; set; }
        public System.Data.Entity.DbSet<sys_DatabaseFirewallRules> sys_DatabaseFirewallRules { get; set; }
        public System.Data.Entity.DbSet<TypUbytovani> TypUbytovani { get; set; }
        public System.Data.Entity.DbSet<TypZajezdu> TypZajezdu { get; set; }
        public System.Data.Entity.DbSet<Ubytovani> Ubytovani { get; set; }
        public System.Data.Entity.DbSet<VazTZajezdTypZajezdu> VazTZajezdTypZajezdu { get; set; }
        public System.Data.Entity.DbSet<VazTZakaznikZajezd> VazTZakaznikZajezd { get; set; }
        public System.Data.Entity.DbSet<Zajezdy> Zajezdy { get; set; }
        public System.Data.Entity.DbSet<Zakaznici> Zakaznici { get; set; }

        public FakeDB_Model()
        {
            Adresa = new FakeDbSet<Adresa>("Id");
            Destinace = new FakeDbSet<Destinace>("Id");
            Doprava = new FakeDbSet<Doprava>("Id");
            Kategorie = new FakeDbSet<Kategorie>("Id");
            KontaktniUdaje = new FakeDbSet<KontaktniUdaje>("Id");
            Pojisteni = new FakeDbSet<Pojisteni>("Id");
            Pojistovny = new FakeDbSet<Pojistovny>("Id");
            Pokoje = new FakeDbSet<Pokoje>("Id", "IdUbytovani", "Kapacita");
            Prilohy = new FakeDbSet<Prilohy>("Id", "IdUbytovani");
            Rezervace = new FakeDbSet<Rezervace>("Id");
            Stravovani = new FakeDbSet<Stravovani>("Id");
            sys_DatabaseFirewallRules = new FakeDbSet<sys_DatabaseFirewallRules>("Id", "Name", "StartIpAddress", "EndIpAddress", "CreateDate", "ModifyDate");
            TypUbytovani = new FakeDbSet<TypUbytovani>("Id");
            TypZajezdu = new FakeDbSet<TypZajezdu>("Id");
            Ubytovani = new FakeDbSet<Ubytovani>("Id");
            VazTZajezdTypZajezdu = new FakeDbSet<VazTZajezdTypZajezdu>("Id", "IdZajezdy", "IdTypZajezdu");
            VazTZakaznikZajezd = new FakeDbSet<VazTZakaznikZajezd>("Id");
            Zajezdy = new FakeDbSet<Zajezdy>("Id");
            Zakaznici = new FakeDbSet<Zakaznici>("Id");

            InitializePartial();
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
// </auto-generated>
