//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoviesActor
    {
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public int Id { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Movies Movy { get; set; }
    }
}
