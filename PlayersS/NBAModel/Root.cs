using System.Collections.Generic;

namespace PlayersS.Model
{
    public class Root
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public List<object> errors { get; set; }
        public int? results { get; set; }
        public List<Response> response { get; set; }
    }
}
