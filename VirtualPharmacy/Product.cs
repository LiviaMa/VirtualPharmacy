namespace VirtualPharmacy
{
    class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int Stock { get; private set; }

        public override string ToString()
        {
            return Name + " "+ Type + " " + Brand;
        }
        public void UpdateStock(string id, int amount)
        {
            if (Id == id)
            {
                Stock += amount;
            }
        }
    }


}
