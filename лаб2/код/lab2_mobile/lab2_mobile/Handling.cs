using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_mobile
{
    public class Handling
    {
        private static Handling instance;

        public static Handling Instance { get { if (instance == null) instance = new Handling(); return Handling.instance; } private set { instance = value; } }

        private Handling () {}

        public List<Data> LoadingData()
        {
            List<Data> listData = new List<Data>();
            DataTable data = new DataTable();
            using (CsvReader csv = new CsvReader(new StreamReader(File.OpenRead("db.csv")), true))
            {
                data.Load(csv);
            }
            string timeString;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][3].ToString() == "192.168.250.59")
                {
                    timeString = data.Rows[i][1].ToString();
                    listData.Add(new Data
                    {
                     
                        Time = Convert.ToString(Convert.ToDateTime(timeString).Hour)+':'+Convert.ToString(Convert.ToDateTime(timeString).Minute),
                        Bytes = Convert.ToDouble(data.Rows[i][11].ToString())
                    });
                    
                }
            }
            return listData;
        }
    }
}
