using RDControl.Domain.Base;

namespace RDControl.Domain.Entities
{
    public class Place : BaseEntity<int>
    {
        public Place()
        {

        }
        public Place(int id, string pname, string address, Client _client)
        {
            Pname = pname;
            Address = address;
            _Client = _client;
        }
        public string Pname { get; set; }
        public string Address { get; set; }
        public Client _Client { get; set; }
    }
}
