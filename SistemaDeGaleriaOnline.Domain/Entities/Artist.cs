using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGaleriaOnline.Domain.Entities;

public class Artist
{
    public string Bio { get; private set; }
    public string PhoneNumber { get; private set; }
    public List<ArtWork>? ArtWorks { get; private set; }
    public List<CategoryArtist> CategoryArtists { get; private set; }

    public Artist(string bio, string phoneNumber,CategoryArtist categoryArtist)
    {
        Bio = bio;
        PhoneNumber = phoneNumber;
        CategoryArtists = new List<CategoryArtist>();
    }

    public void AddArtWork(ArtWork artwork)
    {
        if (artwork is null)
        {
            throw new ArgumentNullException("A obra de arte não pode ser nula!");
        }
        ArtWorks.Add(artwork);
    }


    public void RemoveArtWork(ArtWork artwork)
    {
        ArtWorks.Remove(artwork);
    }
}
