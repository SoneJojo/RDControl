using RDControl.Domain.Base;

namespace RDControl.Domain.Entities
{
    public class Equipment : BaseEntity<int>
    {
        public Equipment()
        {

        }

        public Equipment(int id, string serial, string model, Place place)
        {
            Serial = serial;
            Model = model;
            _Place = place;
        }

        public string Serial { get; set; }
        public string Model { get; set; }
        public Place _Place { get; set; }
    }
}
