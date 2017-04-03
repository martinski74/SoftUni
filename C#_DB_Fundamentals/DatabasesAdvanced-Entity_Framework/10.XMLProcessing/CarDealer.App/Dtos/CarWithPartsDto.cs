using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarDealer.App.Dtos
{
    [XmlType("car")]
    public class CarWithPartsDto
    {

        public CarWithPartsDto()
        {
            this.Parts = new List<PartDto>();
        }
        [XmlAttribute("make")]
        public string Make { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("travelled-distance")]
        public long TravelDistance { get; set; }

        [XmlArray("parts")]
        public List<PartDto> Parts { get; set; }
    }
}
