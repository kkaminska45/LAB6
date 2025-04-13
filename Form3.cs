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
        private int remainingTime;
        private System.Windows.Forms.Timer GameTimer;
        private string[,] plansza;
        private int znalezioneDydelfy = 0;
        private bool krokodylRozbrojony = false;

        private bool krokodylOdkryty = false;
        private System.Windows.Forms.Timer krokodylTimer;

        private System.Windows.Forms.Timer szopTimer;
        private List<Button> szopDoZamkniecia = new List<Button>();
        private HashSet<Point> odkryteDydelfy = new HashSet<Point>(); 
        private HashSet<Point> trwaleOdkryteDydelfy = new HashSet<Point>();

        public FormGra(int wiersze, int kolumny, string czas, int dydelfy, int krokodyle, int szopy)
        {
            InitializeComponent();
            this.GameTimer = new System.Windows.Forms.Timer();
            this.krokodylTimer = new System.Windows.Forms.Timer(); 
            this.krokodylTimer.Tick += KrokodylTimer_Tick;
            this.szopTimer = new System.Windows.Forms.Timer();
            this.szopTimer.Interval = 2000;
            this.szopTimer.Tick += SzopTimer_Tick;
            this.rows = wiersze;
            this.columns = kolumny;
            this.dydelfy = dydelfy;
            this.szopy = szopy;
            this.krokodyle = krokodyle;
            this.czas = czas;
        }

        private void FormGra_Load(object sender, EventArgs e)
        {
            if (rows <= 0 || columns <= 0 || dydelfy < 0 || krokodyle < 0 || szopy < 0)
            {
                MessageBox.Show("Nieprawidłowe dane wejściowe. Gra nie może się rozpocząć.");
                this.Close();
                return;
            }

            if (!int.TryParse(czas, out remainingTime) || remainingTime <= 0)
            {
                MessageBox.Show("Nieprawidłowy czas. Gra nie może się rozpocząć.");
                this.Close();
                return;
            }

            StworzPlansze();
            this.remainingTime = int.Parse(czas);
        }

        private void StworzPlansze()
        {
            int tileSize = 80;
            Random rand = new Random();

            plansza = new string[rows, columns]; 

            void LosujZwierze(string symbol, int ile)
            {
                int dodano = 0;
                while (dodano < ile)
                {
                    int r = rand.Next(rows);
                    int c = rand.Next(columns);
                    if (plansza[r, c] == null)
                    {
                        plansza[r, c] = symbol;
                        dodano++;
                    }
                }
            }

            LosujZwierze("D", dydelfy);     
            LosujZwierze("K", krokodyle);   
            LosujZwierze("S", szopy);       

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button tile = new Button();
                    tile.Size = new Size(tileSize, tileSize);
                    tile.Location = new Point(j * tileSize, i * tileSize);
                    tile.BackColor = Color.LightGray;
                    tile.Text = "";
                    tile.Tag = new Point(i, j);
                    tile.Click += Tile_Click;

                    tile.BackgroundImage = null;
                    tile.BackgroundImageLayout = ImageLayout.Stretch;   

                    this.Controls.Add(tile);
                }
            }

            this.ClientSize = new Size(columns * tileSize, rows * tileSize);

            if (!int.TryParse(czas, out remainingTime))
            {
                MessageBox.Show("Niepoprawny format czasu, ustawiam domyślnie 60 sek.");
                remainingTime = 60;
            }

            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            GameTimer.Start();
        }


        private void Tile_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            Point pos = (Point)clicked.Tag;
            int row = pos.X;
            int col = pos.Y;

            string zawartosc = plansza[row, col];

            if (zawartosc == "D")
            {
                clicked.BackgroundImage = Properties.Resources.dydelf;
                clicked.BackgroundImageLayout = ImageLayout.Stretch;

                clicked.Enabled = false;
                odkryteDydelfy.Add(pos); 

                trwaleOdkryteDydelfy.Add(pos);

                if (trwaleOdkryteDydelfy.Count == dydelfy)  
                {
                    GameTimer.Stop();
                    MessageBox.Show("Brawo, odkryłeś wszystkie Dydelfy! Wygrałeś!");
                    this.Close();
                }
            }
            else if (zawartosc == "K")
            {
                if (!krokodylOdkryty)
                {
                    clicked.Image = Properties.Resources.krokodyl;
                    clicked.ImageAlign = ContentAlignment.MiddleCenter;

                    krokodylOdkryty = true;
                    krokodylRozbrojony = false;
                    krokodylTimer.Interval = 2000;
                    krokodylTimer.Start();
                }
                else if (!krokodylRozbrojony)
                {
                    krokodylRozbrojony = true;
                    krokodylTimer.Stop();

                    clicked.Image = null;

                    clicked.BackColor = Color.LightGray;
                    clicked.Enabled = true;

                    krokodylOdkryty = false;
                    krokodylRozbrojony = false;
                }
            }
            else if (zawartosc == "S")
            {
                clicked.Image = Properties.Resources.szop;
                clicked.ImageAlign = ContentAlignment.MiddleCenter;

                clicked.Enabled = false;

                szopDoZamkniecia.Clear();
                szopDoZamkniecia.Add(clicked);

                Point[] sasiedzi = {
                new Point(row - 1, col),
                new Point(row + 1, col),
                new Point(row, col - 1),
                new Point(row, col + 1)
                };

                foreach (Point sasiad in sasiedzi)
                {
                    if (sasiad.X >= 0 && sasiad.X < rows && sasiad.Y >= 0 && sasiad.Y < columns)
                    {
                        foreach (Control control in this.Controls)
                        {
                            if (control is Button btn && btn.Tag is Point p && p == sasiad)
                            {
                                szopDoZamkniecia.Add(btn);
                            }
                        }
                    }
                }

                szopTimer.Start();
            }
            else
            {
                clicked.Text = null;

                clicked.Enabled = false;
            }
        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            this.Text = $"Czas: {remainingTime}s"; 

            if (remainingTime <= 0)
            {
                GameTimer.Stop();
                MessageBox.Show("Koniec czasu!");
                this.Close(); 
            }
        }
        private void KrokodylTimer_Tick(object sender, EventArgs e)
        {
            krokodylTimer.Stop();

            if (krokodylOdkryty && !krokodylRozbrojony)
            {
                krokodylOdkryty = false;
                MessageBox.Show("Przegrałeś! Nie zareagowałeś wystarczająco szybko.");
                GameTimer.Stop();
                this.Close();
            }
        }
        private void SzopTimer_Tick(object sender, EventArgs e)
        {
            szopTimer.Stop();

            foreach (Button btn in szopDoZamkniecia)
            {
                btn.Image = null; 
                btn.BackgroundImage = null;
                btn.BackColor = Color.LightGray;
                btn.Enabled = true;

                Point pos = (Point)btn.Tag;
                if (plansza[pos.X, pos.Y] == "D")
                {
                    trwaleOdkryteDydelfy.Remove(pos);  
                }
            }

            szopDoZamkniecia.Clear();

            if (trwaleOdkryteDydelfy.Count == dydelfy)  
            {
                GameTimer.Stop();
                MessageBox.Show("Brawo, odkryłeś wszystkie Dydelfy! Wygrałeś!");
                this.Close();
            }
        }


        private bool CzyWszystkieDydelfyOdkryte()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (plansza[i, j] == "D") 
                    {
                        foreach (Control control in this.Controls)
                        {
                            if (control is Button btn && btn.Tag is Point p && p.X == i && p.Y == j)
                            {
                                if (btn.Image == Properties.Resources.dydelf)
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;  
                                }
                            }
                        }
                    }
                }
            }
            return true;  
        }


    }
}
