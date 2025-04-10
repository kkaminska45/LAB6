namespace LAB6
{
    partial class FormUstawienia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxX = new ComboBox();
            comboBoxY = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBoxUstawieniaCzas = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBoxDydelfy = new ComboBox();
            comboBoxKrokodyle = new ComboBox();
            comboBoxSzopy = new ComboBox();
            btnZapiszUstawienia = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(89, 32);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "PLANSZA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(31, 74);
            label2.Name = "label2";
            label2.Size = new Size(24, 28);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(32, 127);
            label3.Name = "label3";
            label3.Size = new Size(23, 28);
            label3.TabIndex = 2;
            label3.Text = "Y";
            // 
            // comboBoxX
            // 
            comboBoxX.FormattingEnabled = true;
            comboBoxX.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxX.Location = new Point(61, 74);
            comboBoxX.Name = "comboBoxX";
            comboBoxX.Size = new Size(151, 28);
            comboBoxX.TabIndex = 3;
            // 
            // comboBoxY
            // 
            comboBoxY.FormattingEnabled = true;
            comboBoxY.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxY.Location = new Point(61, 127);
            comboBoxY.Name = "comboBoxY";
            comboBoxY.Size = new Size(151, 28);
            comboBoxY.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(107, 173);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 6;
            label4.Text = "CZAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 219);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 7;
            label5.Text = "s";
            // 
            // textBoxUstawieniaCzas
            // 
            textBoxUstawieniaCzas.Location = new Point(73, 216);
            textBoxUstawieniaCzas.Name = "textBoxUstawieniaCzas";
            textBoxUstawieniaCzas.Size = new Size(125, 27);
            textBoxUstawieniaCzas.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(295, 35);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 9;
            label6.Text = "Dydelfy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(295, 102);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 10;
            label7.Text = "Krokodyle";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Location = new Point(295, 160);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 11;
            label8.Text = "Szopy";
            // 
            // comboBoxDydelfy
            // 
            comboBoxDydelfy.FormattingEnabled = true;
            comboBoxDydelfy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBoxDydelfy.Location = new Point(402, 36);
            comboBoxDydelfy.Name = "comboBoxDydelfy";
            comboBoxDydelfy.Size = new Size(151, 28);
            comboBoxDydelfy.TabIndex = 12;
            // 
            // comboBoxKrokodyle
            // 
            comboBoxKrokodyle.FormattingEnabled = true;
            comboBoxKrokodyle.Items.AddRange(new object[] { "0", "1" });
            comboBoxKrokodyle.Location = new Point(402, 103);
            comboBoxKrokodyle.Name = "comboBoxKrokodyle";
            comboBoxKrokodyle.Size = new Size(151, 28);
            comboBoxKrokodyle.TabIndex = 13;
            // 
            // comboBoxSzopy
            // 
            comboBoxSzopy.FormattingEnabled = true;
            comboBoxSzopy.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8" });
            comboBoxSzopy.Location = new Point(402, 161);
            comboBoxSzopy.Name = "comboBoxSzopy";
            comboBoxSzopy.Size = new Size(151, 28);
            comboBoxSzopy.TabIndex = 14;
            // 
            // btnZapiszUstawienia
            // 
            btnZapiszUstawienia.Location = new Point(320, 210);
            btnZapiszUstawienia.Name = "btnZapiszUstawienia";
            btnZapiszUstawienia.Size = new Size(211, 29);
            btnZapiszUstawienia.TabIndex = 15;
            btnZapiszUstawienia.Text = "ZAPISZ USTAWIENIA";
            btnZapiszUstawienia.UseVisualStyleBackColor = true;
            btnZapiszUstawienia.Click += btnZapiszUstawienia_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(320, 245);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(211, 29);
            btnAnuluj.TabIndex = 16;
            btnAnuluj.Text = "ANULUJ";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // FormUstawienia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 280);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapiszUstawienia);
            Controls.Add(comboBoxSzopy);
            Controls.Add(comboBoxKrokodyle);
            Controls.Add(comboBoxDydelfy);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxUstawieniaCzas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxY);
            Controls.Add(comboBoxX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUstawienia";
            Text = "Ustawienia";
            Load += FormUstawienia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxX;
        private ComboBox comboBoxY;
        private Label label4;
        private Label label5;
        private TextBox textBoxUstawieniaCzas;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxDydelfy;
        private ComboBox comboBoxKrokodyle;
        private ComboBox comboBoxSzopy;
        private Button btnZapiszUstawienia;
        private Button btnAnuluj;
    }
}