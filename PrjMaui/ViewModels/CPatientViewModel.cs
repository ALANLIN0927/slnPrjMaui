using PrjMaui.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrjMaui.ViewModels
{
   
    public class CPatientViewModel:INotifyPropertyChanged
    {
        List<CPatient> list;
        int _position = 0;

        public event PropertyChangedEventHandler PropertyChanged;
        private SQLiteAsyncConnection _con;
        private SQLiteAsyncConnection getConnection()
        {
            if(_con==null)
            {
                string folder =Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string path = Path.Combine(folder, "dbDemo.db");
                _con = new SQLiteAsyncConnection(path);
                _con.CreateTableAsync<CPatient>();






            }

            return _con;



        }









      

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

            foreach (CPatient t in list)
                getConnection().InsertAsync(t);
        }
        public void moveFirst()
        {
            _position = 0;
            PropertyChanged(this,new PropertyChangedEventArgs("current"));
        }
        public void movePrevious()
        {
            _position--;
            if (_position < 0)
                _position = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveNext()
        {
            _position++;
            if (_position >= list.Count)
                moveLast();
            else
                PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveLast()
        {
            _position=list.Count-1;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveTo(int to)
        {
            _position = to;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
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
                    PropertyChanged(this, new PropertyChangedEventArgs("current"));
                    return list[i];
                    

                }


            }
            return null;
        }
    }
}
