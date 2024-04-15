
using TestConvertChiffreRomain.Services;

namespace TestUnitaireRomains
{
    public class ConvertisseurChiffresRomainsTests
    {
         [Theory]
        [InlineData(1, "I")]    
        [InlineData(10, "X")]
        [InlineData(7, "VII")]
        public void TestConversionEnChiffresRomains(int nombre, string chiffresRomainsAttendus)
        {
            // Act
            string resultat = ConvertisseurChiffresRomains.ConvertirEnChiffresRomains(nombre);

            // Assert
            Assert.Equal(chiffresRomainsAttendus, resultat);
        }
    }
}