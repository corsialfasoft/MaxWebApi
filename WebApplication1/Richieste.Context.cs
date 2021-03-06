﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RICHIESTEEntities : DbContext
    {
        public RICHIESTEEntities()
            : base("name=RICHIESTEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ProdottiSet> ProdottiSet { get; set; }
        public virtual DbSet<RichiesteProdotti> RichiesteProdotti { get; set; }
        public virtual DbSet<RichiesteSet> RichiesteSet { get; set; }
    
        public virtual ObjectResult<Nullable<int>> CreaOrdini(Nullable<int> idRichiesta, Nullable<int> idProdotti, Nullable<int> quantita)
        {
            var idRichiestaParameter = idRichiesta.HasValue ?
                new ObjectParameter("idRichiesta", idRichiesta) :
                new ObjectParameter("idRichiesta", typeof(int));
    
            var idProdottiParameter = idProdotti.HasValue ?
                new ObjectParameter("idProdotti", idProdotti) :
                new ObjectParameter("idProdotti", typeof(int));
    
            var quantitaParameter = quantita.HasValue ?
                new ObjectParameter("quantita", quantita) :
                new ObjectParameter("quantita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CreaOrdini", idRichiestaParameter, idProdottiParameter, quantitaParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CreaRichiesta(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CreaRichiesta", dateParameter);
        }
    
        public virtual ObjectResult<SearchByID_Result> SearchByID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchByID_Result>("SearchByID", idParameter);
        }
    
        public virtual ObjectResult<SearchString_Result> SearchString(string parola)
        {
            var parolaParameter = parola != null ?
                new ObjectParameter("parola", parola) :
                new ObjectParameter("parola", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchString_Result>("SearchString", parolaParameter);
        }
    }
}
