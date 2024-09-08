namespace Purchase
{
    class Store {
        public Department Foods;
        public Department Tech;

        public Store()
        {
            Foods = new Department();
            Tech = new Department();
        }
    }

}

