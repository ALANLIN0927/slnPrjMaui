using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjMaui.Model
{
  public class CTodoItem
    {
        public string todo { get; set; }
        public string date { get; set; }
        public override string ToString()
        {
            return todo + "," + date;
        }
    }
}
