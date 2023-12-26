﻿using NTierECommerce.Entities.Enums;

namespace NTierECommerce.Entities.Interfaces
{
    public interface IEntity<T>
    {
        public int Id { get; set; }
        public T MasterId { get; set; }


        //Create
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }


        //Update
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIpAddress { get; set; }

        public DataStatus Status { get; set; }
        public bool IsActive { get; set; }

    }
}
