using SistemaDeGaleriaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGaleriaOnline.Domain.Entities;

public class User
{
    public int Id { get; private set; }
    public String Name { get; private set; }
    public String Email { get; private set; }
    public String Password { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public RolesEnum Role { get; private set; }
    public bool IsArtist => PerfilArtist != null;
    public Artist? PerfilArtist { get; private set; }

    public User(string name, string email, string password, RolesEnum role)
    {
        Name = name;
        Email = email;
        Password = password;
        CreatedAt = DateTime.Now;
        Role = role;
    }

    public void BecameArtist(Artist artist)
    {
        if (artist is null)
        {
            throw new ArgumentNullException("O artista não pode ser nulo!");
        }
        PerfilArtist = artist;
        Role = RolesEnum.artist;
    }
}
