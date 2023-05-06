using System.Collections.Generic;

namespace PlayersS.Model
{
    public class Response
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Birth birth { get; set; }
        public Nba nba { get; set; }
        public Height height { get; set; }
        public Weight weight { get; set; }
        public string college { get; set; }
        public string affiliation { get; set; }
        public Dictionary<string, Liga> leagues { get; set; }
    }
}
