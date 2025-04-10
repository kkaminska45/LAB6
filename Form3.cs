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
    public partial class FormGra : Form
    {
        private int rows, columns;
        private int dydelfy, szopy, krokodyle;
        private string czas;
        public FormGra(int wiersze, int kolumny, string czas, int dydelfy, int krokodyle, int szopy)
        {
            InitializeComponent();
            this.rows = wiersze;
            this.columns = kolumny;
            this.dydelfy = dydelfy;
            this.szopy = szopy;
            this.krokodyle = krokodyle;
            this.czas = czas;
        }

        private void FormGra_Load(object sender, EventArgs e)
        {

        }


    }
}
