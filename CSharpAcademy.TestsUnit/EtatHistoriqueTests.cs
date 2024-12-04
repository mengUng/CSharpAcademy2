namespace CSharpAcademy.TestsUnit
{
    public class EtatHistoriqueTests
    {
        [Fact]
        public void AjouterHistorique_ParametreEtat_EtatAjouterDansHistorique()
        {
            // Arrange
            var historique = new EtatHistorique();
            var etat = "PorteFermee";

            // Act
            historique.AjouterHistorique(etat);

            // Redirection de la sortie Console en mémoire 
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            historique.Afficher();

            // Assert
            var output = consoleOutput.ToString();
            Assert.Contains("PorteFermee", output);
        }

        [Fact]
        public void Afficher_AfficheHistoriqueCorrectement()
        {
            // Arrange
            var historique = new EtatHistorique();
            historique.AjouterHistorique("PorteFermee");
            historique.AjouterHistorique("PorteOuverte");
            historique.AjouterHistorique("PorteVerrouillee");

            // Redirect Console Output to Verify Affichage
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            historique.Afficher();

            // Assert
            var output = consoleOutput.ToString();
            Assert.Contains("PorteFermee", output);
            Assert.Contains("PorteOuverte", output);
            Assert.Contains("PorteVerrouillee", output);
        }
    }
}