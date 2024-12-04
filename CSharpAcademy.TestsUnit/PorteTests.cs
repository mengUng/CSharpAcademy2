namespace CSharpAcademy.TestsUnit
{
    public class PorteTests
    {
        [Fact]
        public void Porte_InitialiseAvecEtatInitial_AjouteEtatInitialDansHistorique()
        {
            // Arrange
            var initialState = new PorteFermee();

            // Act
            var porte = new Porte(initialState);

            
            // Redirection de la sortie Console en mémoire 
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            porte.AfficherEtatHistorique();

            // Assert
            var output = consoleOutput.ToString();
            Assert.Contains("PorteFermee", output);
            
        }

        [Fact]
        public void ChangerEtat_ChangerEtatDeLaPorte_AjouteNouvelEtatDansHistorique()
        {
            // Arrange
            var porte = new Porte(new PorteFermee());
            var nouvelEtat = new PorteOuverte();

            // Act
            porte.ChangerEtat(nouvelEtat);

            // Redirection de la sortie Console en mémoire 
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Affiche les états enregistrées
            porte.AfficherEtatHistorique();

            // Assert
            var output = consoleOutput.ToString();
            Assert.Contains("PorteFermee", output);
            Assert.Contains("PorteOuverte", output);
        }

        [Fact]
        public void ChangerEtat_AvecPlusieursTransitions_EnregistreTousLesEtats()
        {
            // Arrange
            var porte = new Porte(new PorteFermee());
            var etatOuvert = new PorteOuverte();
            var etatVerrouille = new PorteVerrouillee();

            // Act
            porte.ChangerEtat(etatOuvert);
            porte.ChangerEtat(etatVerrouille);

            // Redirection de la sortie Console en mémoire 
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Affiche les états enregistrées
            porte.AfficherEtatHistorique();

            // Assert
            var output = consoleOutput.ToString();
            Assert.Contains("PorteFermee", output);
            Assert.Contains("PorteOuverte", output);
            Assert.Contains("PorteVerrouillee", output);
        }
    }
}