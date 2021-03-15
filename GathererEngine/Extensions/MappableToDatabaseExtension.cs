using GathererEngine.Database;
using System.ComponentModel.DataAnnotations;

namespace GathererEngine.Extensions
{
    public abstract class MappableToDatabaseExtension
    {
        [Key]
        public int WMIID { get; set; }
        public WmiResultsSetEntity WmiResultsSetEntity { get; set; }
    }
}
