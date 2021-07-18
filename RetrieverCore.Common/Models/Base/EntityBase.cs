using System;
using System.ComponentModel.DataAnnotations;

namespace Databases.RetrieverCore.Common.Models.Base
{
    public abstract class EntityBase
    {
        [Key]
        public int ID { get; set; }
        public Guid SetID { get; set; }
        public bool Deleted { get; set; }
    }
}
