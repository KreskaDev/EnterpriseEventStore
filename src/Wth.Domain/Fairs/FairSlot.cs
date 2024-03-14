using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Wth.Domain.Brands;

namespace Wth.Domain.Fairs
{
    public class FairSlot
    {
        public BrandId Brand { get; set; }

        public FairSlotSize Size { get; set; }

        public List<FairEquipment> FairEquipments { get; set; } = new();
    }
}
