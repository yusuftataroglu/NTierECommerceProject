﻿using NTierECommerce.Entities.Base;

namespace NTierECommerce.Entities.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public string ImagePath { get; set; }

        //todo: birden fazla görsel eklemek için "ProductImage" isimli bir class oluşturularak ilişkilendirme gerçekleştirilecek.

        

        //Mapping
        public  int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
