using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarDealer.App.Dtos
{
    [XmlType("part")]
    public class PartDto
    {
        [XmlAttribute("name")]
        public string Part { get; set; }
        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
