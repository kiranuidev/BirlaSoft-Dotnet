﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStoreApp.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MvcMusicStoreEntities : DbContext
    {
        public MvcMusicStoreEntities()
            : base("name=MvcMusicStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<USP_GET_ALBUMBYID_Result> USP_GET_ALBUMBYID(Nullable<int> aLBUMID)
        {
            var aLBUMIDParameter = aLBUMID.HasValue ?
                new ObjectParameter("ALBUMID", aLBUMID) :
                new ObjectParameter("ALBUMID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GET_ALBUMBYID_Result>("USP_GET_ALBUMBYID", aLBUMIDParameter);
        }
    
        public virtual ObjectResult<USP_GET_ALBUMS_Result> USP_GET_ALBUMS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GET_ALBUMS_Result>("USP_GET_ALBUMS");
        }
    
        public virtual ObjectResult<USP_GET_ARTISTS_Result> USP_GET_ARTISTS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GET_ARTISTS_Result>("USP_GET_ARTISTS");
        }
    
        public virtual ObjectResult<USP_GET_Genre_Result> USP_GET_Genre()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GET_Genre_Result>("USP_GET_Genre");
        }
    
        public virtual int USP_INSERT_ALBUM(Nullable<int> gENREID, Nullable<int> aRTISTID, string tITLE, Nullable<int> pRICE, string aLBUMARTURL)
        {
            var gENREIDParameter = gENREID.HasValue ?
                new ObjectParameter("GENREID", gENREID) :
                new ObjectParameter("GENREID", typeof(int));
    
            var aRTISTIDParameter = aRTISTID.HasValue ?
                new ObjectParameter("ARTISTID", aRTISTID) :
                new ObjectParameter("ARTISTID", typeof(int));
    
            var tITLEParameter = tITLE != null ?
                new ObjectParameter("TITLE", tITLE) :
                new ObjectParameter("TITLE", typeof(string));
    
            var pRICEParameter = pRICE.HasValue ?
                new ObjectParameter("PRICE", pRICE) :
                new ObjectParameter("PRICE", typeof(int));
    
            var aLBUMARTURLParameter = aLBUMARTURL != null ?
                new ObjectParameter("ALBUMARTURL", aLBUMARTURL) :
                new ObjectParameter("ALBUMARTURL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_INSERT_ALBUM", gENREIDParameter, aRTISTIDParameter, tITLEParameter, pRICEParameter, aLBUMARTURLParameter);
        }
    }
}
