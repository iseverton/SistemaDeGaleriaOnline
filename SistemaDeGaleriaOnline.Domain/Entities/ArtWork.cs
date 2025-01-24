using SistemaDeGaleriaOnline.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGaleriaOnline.Domain.Entities;

public class ArtWork : BaseEntity
{
    public Decimal Price { get; private set; }
    public string ImageUrl { get; private  set; }
    public bool IsAvailable { get;private set; }
    public Artist Artist { get;private set; }
    public CategoryArtWork Category { get; private set; }

    public ArtWork(string name,string description,decimal price, string imageUrl, CategoryArtWork category)
    {
        Name = name;
        Description = description;
        Price = price;
        ImageUrl = imageUrl;
        IsAvailable = true;
        Category = category;
        CreatedAt = DateTime.Now;
        LastUpdatedAt = DateTime.Now;
    }
}
