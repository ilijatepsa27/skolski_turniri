using System;
using System.Drawing;
using System.Windows.Forms;

namespace SkolskiTurniri
{
    public class DodajTurnir : Form
    {
        public DodajTurnir()
        {
            Text = "Dodaj turnir";

            Label naziv = new Label();
            naziv.Text = "Naziv turnira:";
            naziv.Location = new Point(20, 20);
            Controls.Add(naziv);

            TextBox unosNaziv = new TextBox();
            unosNaziv.Location = new Point(150, 20);
            Controls.Add(unosNaziv);

            Label sport = new Label();
            sport.Text = "Sport:";
            sport.Location = new Point(20, 60);
            Controls.Add(sport);

            TextBox unosSport = new TextBox();
            unosSport.Location = new Point(150, 60);
            Controls.Add(unosSport);

            Label datum = new Label();
            datum.Text = "Datum:";
            datum.Location = new Point(20, 100);
            Controls.Add(datum);

            TextBox unosDatum = new TextBox();
            unosDatum.Location = new Point(150, 100);
            Controls.Add(unosDatum);

            Label vreme = new Label();
            vreme.Text = "Vreme:";
            vreme.Location = new Point(20, 140);
            Controls.Add(vreme);

            TextBox unosVreme = new TextBox();
            unosVreme.Location = new Point(150, 140);
            Controls.Add(unosVreme);

            Label mesto = new Label();
            mesto.Text = "Mesto:";
            mesto.Location = new Point(20, 180);
            Controls.Add(mesto);

            TextBox unosMesto = new TextBox();
            unosMesto.Location = new Point(150, 180);
            Controls.Add(unosMesto);

            Label organizator = new Label();
            organizator.Text = "Organizator:";
            organizator.Location = new Point(20, 220);
            Controls.Add(organizator);

            TextBox unosOrganizator = new TextBox();
            unosOrganizator.Location = new Point(150, 220);
            Controls.Add(unosOrganizator);

            Label cena = new Label();
            cena.Text = "Cena:";
            cena.Location = new Point(20, 260);
            Controls.Add(cena);

            TextBox unosCena = new TextBox();
            unosCena.Location = new Point(150, 260);
            Controls.Add(unosCena);

            Button sacuvaj = new Button();
            sacuvaj.Text = "Sacuvaj";
            sacuvaj.Location = new Point(150, 310);
            Controls.Add(sacuvaj);

            sacuvaj.Click += (s, e) =>
            {
                MessageBox.Show("Turnir je sacuvan!");
            };
        }
    }
}