using SistemaDeGaleriaOnline.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGaleriaOnline.Domain.Entities
{
    public class CategoryArtist : BaseEntity
    {
        public List<Artist> Artist { get; private set; }

        public CategoryArtist(string name, string description)
        {
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
            LastUpdatedAt = DateTime.Now;
        }
    }
}
