using RDControl.Domain.Base;
namespace RDControl.Domain.Entities
{
    public class Technician : BaseEntity<int>
    {
        public enum TechnicianType
        {
            Internal,
            External
        }

        public Technician()
        {

        }
        public Technician(int id, string name, string cpf, TechnicianType technicianType)
        {
            TechType = technicianType;
            Name = name;
            CPF = cpf;
        }
        public string Name { get; set; }
        public string CPF { get; set; }
        public TechnicianType TechType { get; set; }
    }
}
