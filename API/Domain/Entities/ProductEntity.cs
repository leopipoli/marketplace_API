﻿namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public int Type { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public string TradeFor { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public CityEntity City { get; set; }
        public int UrgencyType { get; set; }
        public DateTime LimitDate { get; set; }
        public IEnumerable<PhotoEntity> Photos { get; set; }
    }
}
