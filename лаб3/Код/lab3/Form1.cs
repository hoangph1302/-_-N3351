using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            string customer = nameCustomer.Text + ", ИНН " + innCustomer.Text + ",КПП " + kpiCustomer.Text;
            string user = nameCompany.Text + ", ИНН " + innCompany.Text + ",КПП " + kppCompany.Text;
            List<string> setValue = new List<string>() {customer,user,numberBill.Text,date.Text,bank.Text,bikCompany.Text,numberCompany.Text};
            List<string> fielName = new List<string>() {"customer","user","billNumber", "date","bank","bik","number1"};


           fillValue(setValue,fielName);
        }
       void fillValue(List<string> setValue, List<string> fieldNames)
        {


            var WordApp = new Word.Application();

            Word.Document doc = null;

            Word.Bookmarks bookmarks = null;

            Word.Bookmark myBookmark = null;

            Word.Range bookmarkRange = null;



            WordApp.Visible = false;

            WordApp.Documents.Open("bill.docx");

            doc = WordApp.ActiveDocument;

            bookmarks = doc.Bookmarks;

            int i = 0;
            foreach (string item in fieldNames)
            {
                myBookmark = bookmarks[item];

                bookmarkRange = myBookmark.Range;
                bookmarkRange.Text = setValue[i];
                i++;
            }

            WordApp.Documents.Close();
            WordApp.Quit();


        }

        private void print_Click(object sender, EventArgs e)
        {
            // Load the document from disk.
            Word.Document doc = new Word.Document("bill.doc");
            // Save as PDF
            doc.Save("bill.pdf");
            MessageBox.Show("open file bill.pdf!");
        }
    }
}


