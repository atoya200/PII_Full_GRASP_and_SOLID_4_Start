namespace Full_GRASP_And_SOLID
{
    public class Item
    {
        protected Item(string description, double cost)
        {
            this.Description = description;
            this.Cost = cost;
        }

        public string Description { get; set; }

        public double Cost { get; set; }
    }
}