namespace Kerteszkedes
{
    public class Garden {
        private List<Parcell> parcells;

        public Garden (int c) {
            parcells = new List<Parcell>();
            for (int i = 0; i < c; i++) {
                parcells.Add(new Parcell());
            }
        }

        public void Plant(int where, Plant what){
            parcells[where] = what;
        }

        
    }

}

