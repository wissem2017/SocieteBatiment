namespace Core.Entities
{
    class Owner: EntityBase
    {
        public string FullName { get; set; }
        public Address Adress { get; set; }
        public string Tel { get; set; }
        public string Avatar { get; set; }

    }

}
