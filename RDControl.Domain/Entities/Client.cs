using RDControl.Domain.Base;

namespace RDControl.Domain.Entities
{
    public class Client : BaseEntity<int>
    {
        public Client()
        {

        }
        public Client(int id, string name, string cnpj)
        {
            Name = name;
            CNPJ = cnpj;
        }
        public string Name { get; set; }
        public string CNPJ { get; set; }
    }
}
