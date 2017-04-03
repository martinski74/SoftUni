using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarDealer.App.Dtos
{
    [XmlType("sale")]
    public class CarWithDiscountDto
    {
        [XmlAttribute("make")]
        public string Make { get; set; }
        [XmlAttribute("model")]
        public string Model { get; set; }
        [XmlAttribute("travelled-distance")]
        public long TraveledDistance { get; set; }
        [XmlElement("customer-name")]
        public string CustomerName { get; set; }
        [XmlElement("discount")]
        public int Discount { get; set; }
        [XmlElement("price")]
        public decimal Price { get; set; }
        [XmlElement("price-with-discount")]
        public decimal PriceWithDiscount
        {
            get { return Price * (1 - Discount); }
            set
            {

            }
        }
    }
}
