using PrjMaui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrjMaui.ViewModels
{
   
    public class CPatientViewModel
    {
        List<CPatient> list;
        int _position = 0;
        public CPatientViewModel()
        {
           loadData();
        }
        private void loadData()
        {
           list= new List<CPatient>();
            list.Add(new CPatient() { fAddress = "Taipei", fEmail = "marco@gmail.com", fId = 1, fName = "Marco", fPhone = "0936541111" });
            list.Add(new CPatient() { fAddress = "台中", fEmail = "a2233@gmail.com", fId = 2, fName = "Alan", fPhone = "0936541111" });
            list.Add(new CPatient() { fAddress = "高雄", fEmail = "a1122@gmail.com", fId = 3, fName = "Marry", fPhone = "0936541111" });
        }
        public void moveFirst()
        {
            _position = 0;
        }
        public void movePrevious()
        {
            _position--;
            if (_position < 0)
                _position = 0;
        }
        public void moveNext()
        {
            _position++;
            if (_position >= list.Count)
                moveLast();
        }
        public void moveLast()
        {
            _position=list.Count-1;
        }
        public void moveTo(int to)
        {
            _position = to;
        }
        public CPatient current
        {
            get { return list[_position]; }
            set { list[_position] = value; }
        }
        public List<CPatient> all
        {
            get { return list; }
            set { list = value; }
        }
        public CPatient findByKeyword(string keyword)
        {
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].fName.ToUpper().Contains(keyword.ToUpper())
            || list[i].fPhone.ToUpper().Contains(keyword.ToUpper())
            || list[i].fEmail.ToUpper().Contains(keyword.ToUpper())
            || list[i].fAddress.ToUpper().Contains(keyword.ToUpper()))
                {
                    _position = i;
                    return list[i];
                    

                }


            }
            return null;
        }
    }
}
