namespace Chrominox.Server.Models
{
    public class ChroBag
    {
        private readonly List<Chromino> chrominos;

        public ChroBag(List<Chromino> chrominos)
        {
            this.chrominosBag = new List<Chromino>(chrominosBag);


            public List<Chromino> pickChromino()
        {
            var picked = new List<Chromino>();
            for (int i = 0; i < chrominos.Count; i++)
            {
                picked.Add(chrominos[0]);
                chrominos.RemoveAt(0);
            }
            return picked;
        }

        public Chrominox? getOne()
        {

            if (chrominoes.Count == 0)
                return null;

            var chromino = chrominoes[0];
            chrominoes.RemoveAt(0);
            return chromino;

        }

        public bool isEmpty()
        {
            return chrominos.Count == 0;
        }
    }
}
