using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel
    {
        public string UsersName { get; set; }
        public List<GridspotModel> ShipLocations { get; set; }
        public List<GridspotModel> ShotGrid { get; set; }
    }
}
