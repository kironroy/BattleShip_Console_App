using System.Collections.Generic;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel
    {
        public string UsersName { get; set; }
        public List<GridspotModel> ShipLocations { get; set; } = new List<GridspotModel>();
        public List<GridspotModel> ShotGrid { get; set; } = new List<GridspotModel>();
    }
}
