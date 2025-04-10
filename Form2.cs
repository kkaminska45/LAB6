using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class FormUstawienia : Form
    {
        private Form1 glowneOkno;
        public FormUstawienia(Form1 okno)
        {
            InitializeComponent();
            glowneOkno = okno;
        }

        private void FormUstawienia_Load(object sender, EventArgs e)
        {

        }

        private void btnZapiszUstawienia_Click(object sender, EventArgs e)
        {
            int rows = (int)comboBoxX.SelectedItem;
            int columns = (int)comboBoxY.SelectedItem;
            string time = textBoxUstawieniaCzas.Text;
            int dydelfy = (int)comboBoxDydelfy.SelectedItem;
            int szopy = (int)comboBoxSzopy.SelectedItem;
            int krokodyle = (int)comboBoxKrokodyle.SelectedItem;

            glowneOkno.PrzekazUstawienia(rows, columns, time, dydelfy, szopy, krokodyle);

            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
