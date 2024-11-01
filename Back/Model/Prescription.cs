using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Model
{
    internal class Prescription
    {
        public long Id;
        public string NameDoctor = string.Empty;
        public int CoveragePorcentage;
        public DateOnly IssueDate;
        public DateOnly ExpirationDate;
    }
}
