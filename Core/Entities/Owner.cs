﻿namespace Core.Entities
{
    class Owner: EntityBase
    {
        public string FullName { get; set; }
        public Address Adress { get; set; }
        public string Tel { get; set; }
        public Image Avatar { get; set; }

    }

}
