using SistemaDeGaleriaOnline.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGaleriaOnline.Domain.Entities;

public class CategoryArtWork : BaseEntity
{
    public List<ArtWork> ArtWorks { get; set; }

    public CategoryArtWork(string name,string description)
    {
        Name = name;
        Description = description;
        ArtWorks = new List<ArtWork>();
        CreatedAt = DateTime.Now;
        LastUpdatedAt = DateTime.Now;
    }
}
