using System;
using System.Drawing;
using System.Windows.Forms;

namespace SkolskiTurniri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label naslov = new Label();
            naslov.Text = "Skolski turniri";
            naslov.Location = new Point(100, 30);
            naslov.AutoSize = true;
            this.Controls.Add(naslov);

            Button btnTurniri = new Button();
            btnTurniri.Text = "Pogledaj turnire";
            btnTurniri.Location = new Point(100, 80);
            this.Controls.Add(btnTurniri);

            Button btnDodaj = new Button();
            btnDodaj.Text = "Dodaj turnir";
            btnDodaj.Location = new Point(100, 130);
            this.Controls.Add(btnDodaj);
            
            btnDodaj.Click += (s, e) =>
{
    DodajTurnir prozor = new DodajTurnir();
    prozor.Show();
};

            Button btnRezultati = new Button();
            btnRezultati.Text = "Rezultati";
            btnRezultati.Location = new Point(100, 180);
            this.Controls.Add(btnRezultati);

            Button btnIzlaz = new Button();
            btnIzlaz.Text = "Izlaz";
            btnIzlaz.Location = new Point(100, 230);
            btnIzlaz.Click += (s, e) => Application.Exit();
            this.Controls.Add(btnIzlaz);
        }
    }
}
