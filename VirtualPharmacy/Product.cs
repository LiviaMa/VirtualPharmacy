namespace VirtualPharmacy
{
    class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return Name + " "+ Type + " " + Brand;
        }
    }


}
