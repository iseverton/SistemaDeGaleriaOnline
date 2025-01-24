using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeGaleriaOnline.Domain.Entities;
using SistemaDeGaleriaOnline.Domain.Enums;

namespace SistemaDeGaleriaOnline.Tests.Entities;

public class UserTests
{
    CategoryArtWork pintura = new CategoryArtWork("Pintura", "Obra feita a mão");
    User user = new User("Leonardo da Vinci", "LeonardpVinci12@gmail.com", "12345", RolesEnum.user);
    //ArtWork artWork = new ArtWork("Mona Lisa", "era uma vez.", 1000, "monalise.png", pintura);

    [Fact]
    public void CreateUserArtist() 
    {
        // Arrange
        User user = new User("Leonardo da Vinci", "LeonardpVinci12@gmail.com","12345",RolesEnum.user);
        Artist artist = new Artist("Meu nome é Leonardo da Vinci","8298767544");

        // Act
        user.BecameArtist(artist);

        // Assert
        Assert.True(user.IsArtist);
        Assert.NotNull(user.PerfilArtist);
    }

    [Fact]
    public void ArtistAddArtWork()
    {
        // Arrange
        
    }
}
