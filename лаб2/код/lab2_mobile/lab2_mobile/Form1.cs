using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_mobile
{
    public partial class NetFlow : Form
    {
        public NetFlow()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            List<Data> listData = new List<Data>();
            listData = Handling.Instance.LoadingData();
        
            List<Data> newData = new List<Data>();

            for (int i = 0; i < listData.Count - 1; i++)
            {
                if (i == listData.Count - 2)
                {
                    if (listData[i].Time == listData[i + 1].Time)
                    {
                        listData[i + 1].Bytes += listData[i].Bytes;
                        newData.Add(listData[i + 1]);
                    }
                    else
                    {
                        newData.Add(listData[i]);
                        newData.Add(listData[i+1]);
                    }
                }
                else
                {
                    if (listData[i].Time == listData[i + 1].Time)
                    {
                        listData[i + 1].Bytes += listData[i].Bytes;

                    }
                    else
                        newData.Add(listData[i]);
                }

            }

            double sum=0;
            double price;
            foreach (Data item in newData)
            {
                chartData.Series["Bytes"].Points.AddXY(item.Time, item.Bytes);
                sum += item.Bytes;
            }

            chartData.Titles.Add("График зависимости объема трафика от времени");


            sum = (sum / 1204) / 1024;
            if (sum < 500)
                price = sum * 0.5;
            else
                price = (sum - 500) * 1 + 500 * 0.5;

            //тармфикация
            CultureInfo cultureRu = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentCulture = cultureRu;


            textBoxSum.Text = sum.ToString();
            textBoxMoney.Text = price.ToString("c");
            
            

        }
    }
}
