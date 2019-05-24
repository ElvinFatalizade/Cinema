using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homepracticaCinema.Forms
{
    public partial class Hall : Form
    {

        private decimal _seatCount;
        private decimal _seatColumn;

        private List<Button> _selectedSeat = new List<Button>();
      
        public Hall(decimal SeatCount, decimal SeatColumn)
            
        {

            this._seatColumn = SeatColumn;
            this._seatCount = SeatCount;

            InitializeComponent();
            this.createSeats();
           

          


        }

        private void Hall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createSeats()
        {
            int x = 20;
            int y = 20;
            for (int i = 0; i< this._seatCount; i++)
            {
                Button button = new Button();
                button.Text = (i+1).ToString();
                button.BackColor = Color.LightGray;
                button.ForeColor = Color.Black;
                button.Location = new Point(x, y);
                button.Size = new Size(30, 30);
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                button.Click += new EventHandler(Allseat_Click);


               

                PnlSeats.Controls.Add(button);

                x += 40;

                if ((i + 1) % this._seatColumn == 0)
                {
                    x = 20;
                    y += 40;
                }
            }

            
         

        }

        private void Hall_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Allseat_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if (clicked.BackColor == Color.LightGray)
            {
                clicked.BackColor = Color.Yellow;
               

                this._selectedSeat.Add(clicked);

                this.CalcTotalPrice();
                this.DisplaySeat();
                //selcet
            }
            else if (clicked.BackColor == Color.Yellow)
            {
                clicked.BackColor = Color.LightGray;
                this._selectedSeat.Remove(clicked);
                this.DisplaySeat();
                this.CalcTotalPrice();
                // unselect
            }
            else
            {
              DialogResult r= MessageBox.Show("Bileti legv etmek isteyirsinizmi?", "Bilet Legvi", MessageBoxButtons.YesNo);
                //cancel order
                if (r == DialogResult.Yes)
                {
                    clicked.BackColor = Color.LightGray;
                    clicked.ForeColor = Color.Black;
                }
            }

        }

        private void CalcTotalPrice()

        {

            if (this._selectedSeat.Count == 0)
            {
                LblPrice.Text = "";

            }
            else
            {
                 LblPrice.Text = (this._selectedSeat.Count * 5).ToString() + " azn ";
            }
         
        }

        private void DisplaySeat()
        {
            LblSeat.Text = string.Join(",", this._selectedSeat.Select(s => s.Text).ToArray());
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (this._selectedSeat.Count == 0)
            {
                MessageBox.Show("Hec bir stul secilmeyib");
                return;
            }
            foreach (Button seat in this._selectedSeat)
            {
                seat.BackColor = Color.Green;
                seat.ForeColor = Color.White;

                this.LblPrice.Text = "";
                this.LblSeat.Text = "";
            }

            this._selectedSeat.Clear();

            MessageBox.Show("Bilet satildi");
        }
    }
    }
