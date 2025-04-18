using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        /// Atributos
        public double AdditionalCharge { get; set; }
        /// Construtor padrão
        public OutsourcedEmployee()
        {
        }
        /// Construtor com parâmetros
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        /// Sobrescrita do método Payment para calcular o pagamento do funcionário terceirizado
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }

    }
}
