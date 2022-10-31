using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_dom
{
    internal class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            hidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; private set; }
        public override string Description
        {
            get
            {
                return base.Description + " Ktoś może się ukrywać w: " + HidingPlaceName + ".";
            }
        }
    }
}
