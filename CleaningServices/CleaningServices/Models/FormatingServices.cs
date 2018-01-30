using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleaningServices.Models
{
    public class FormatingServices
    {
        public string AsReadableDate(DateTime date)
        {
            return date.ToString("d");
        }
    }
}
