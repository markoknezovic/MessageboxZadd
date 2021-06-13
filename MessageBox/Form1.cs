using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKutijaZaUpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string poruka = "Odaberite Yes / No / Cancel";

            string naslov = "Naslovna linija Dijaloga za poruke";

            DialogResult rez = MessageBox.Show(poruka, naslov, MessageBoxButtons.YesNoCancel);
            
            switch (rez)

            {

                case DialogResult.Yes:

                    textBoxRezultat.Text = "Izabrali ste dugme YES";

                    break;

                case DialogResult.No:

                    textBoxRezultat.Text = "Izabrali ste dugme NO";

                    break;

                case DialogResult.Cancel:

                    textBoxRezultat.Text = "Izabrali ste dugme Cancel";

                    break;

            }

        }
    }
}
