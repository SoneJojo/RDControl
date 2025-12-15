namespace RDControl.App.ViewModel
{
    public class ReportViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Equip { get; set; }
        public string Situation { get; set; }
        public string _Technician { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public decimal Hours_price { get; set; }
        public string Observation { get; set; }
        public string Ticket { get; set; }
        public string _User { get; set; }
        public string Payment { get; set; }
    }
}
