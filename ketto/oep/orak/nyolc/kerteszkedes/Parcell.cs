namespace Kerteszkedes
{
    public class Parcell {
        public class AlreadyPlantedException : Exception;

        private int plantTime;
        private Plant type;

        public void Plant(Plant p) {
            if (type != null) {
                throw new AlreadyPlantedException();
            }
            type = p;
            plantTime = DateTime.Now.Month;

        }

        public bool Done(int month) {
            return type != null && type is Vegetable && month - plantTime >= type.RipeningTime;
        }
    }

}

