namespace Chrominox.Server.Services
{
    public class ChroGameFactory
    {
        private ChroGame() currentGame;
        private ChrominoGenerator chrominoGenerator;

        public ChroGameFactory(ChrominoGenerator chrominoGenerator)
        {
            this.chrominoGenerator = chrominoGenerator;
        }

        public void newGame(GameMode mode)
        {
            List<Chromino> chrominos = chrominoGenerator.generateChrominos();
            currentGame = new ChroGame(mode, chrominos);
            ChroBag bag = new ChroBag(chrominos);
        }
    }
}
