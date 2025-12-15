using RDControl.Domain.Base;

namespace RDControl.Domain.Entities
{
    public class Report : BaseEntity<int>
    {
        public enum PaymentType
        {
            CreditCard,
            DebitCard,
            Cash,
            Pix,
            Other
        }

        public enum SituationType
        {
            Open,
            Quoted,
            Finished,
            InGuarantee,
            NotAproved
        }
        public Report()
        {

        }
        public Report(int id, DateTime date, Equipment equip, SituationType situation, Technician technician, string description, decimal hours, decimal hours_price, string observation, string ticket_reason, PaymentType payment_type, User user)
        {
            _User = user;
            Date = date;
            Equip = equip;
            Situation = situation;
            _Technician = technician;
            Description = description;
            Hours = hours;
            Hours_price = hours_price;
            Observation = observation;
            Ticket = ticket_reason;
            Payment = payment_type;
        }
        public DateTime Date { get; set; }
        public Equipment Equip { get; set; }
        public SituationType Situation { get; set; }
        public Technician _Technician { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public decimal Hours_price { get; set; }
        public string Observation { get; set; }
        public string Ticket { get; set; }
        public User _User { get; set; }
        public PaymentType Payment { get; set; }
    }
}