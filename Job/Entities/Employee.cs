using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Entities
{
    internal class Employee
    {
        /// Atributos
        public String Name{ get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        /// Construtor padrão
        public Employee()
        {
        }

        /// Construtor com parâmetros
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        /// Método para calcular o pagamento do funcionário
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
