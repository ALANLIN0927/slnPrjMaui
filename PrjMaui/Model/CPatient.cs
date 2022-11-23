using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjMaui.Model
{
    public class CPatient
    {
        [PrimaryKey,AutoIncrement]
        public  int fId { get; set; }
        public string fName { get; set; }
        public string fPhone { get; set; }
        public string fEmail { get; set; }
        public string fAddress { get; set; }
        public override string ToString(){ return this.fName + "/" + this.fEmail+"/"+this.fPhone+"/"+this.fAddress; }
       








    }
}
