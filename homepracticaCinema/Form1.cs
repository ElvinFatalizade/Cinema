using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homepracticaCinema
{
    public partial class Form1 : Form
    {
        List<int> _ages = new List<int>();
        public Form1()
        {
            InitializeComponent();

            Print();
        }

       private void Print()
        {
            _ages.Add(23);
            _ages.Add(12);
            _ages.Add(65);
            _ages.Add(12);


            foreach(int ages in _ages)
            {
                DgvAges.Rows.Add(ages.ToString());
            }

         
        }
    }
}
