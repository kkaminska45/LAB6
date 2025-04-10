using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LAB6
{
    public partial class Form1 : Form
    {
        private int rows, columns;
        private int dydelfy, szopy, krokodyle;
        private string time;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUSTAWIENIA_Click(object sender, EventArgs e)
        {
            FormUstawienia form2 = new FormUstawienia(this);
            form2.Show();
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            FormGra formGry = new FormGra(rows, columns, time, dydelfy, szopy, krokodyle);
            formGry.Show();
        }

        public void PrzekazUstawienia(int wiersze, int kolumny, string czas, int dydelfy, int krokodyle, int szopy)
        {
            this.rows = wiersze;
            this.columns = kolumny;
            this.dydelfy = dydelfy;
            this.szopy = szopy;
            this.krokodyle = krokodyle;
            this.time = czas;
        }
    }
}
