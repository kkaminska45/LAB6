namespace LAB6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSTART = new Button();
            btnUSTAWIENIA = new Button();
            btnKONIEC = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSTART
            // 
            btnSTART.Location = new Point(99, 99);
            btnSTART.Name = "btnSTART";
            btnSTART.Size = new Size(128, 29);
            btnSTART.TabIndex = 0;
            btnSTART.Text = "START";
            btnSTART.UseVisualStyleBackColor = true;
            btnSTART.Click += btnSTART_Click;
            // 
            // btnUSTAWIENIA
            // 
            btnUSTAWIENIA.Location = new Point(99, 148);
            btnUSTAWIENIA.Name = "btnUSTAWIENIA";
            btnUSTAWIENIA.Size = new Size(128, 29);
            btnUSTAWIENIA.TabIndex = 1;
            btnUSTAWIENIA.Text = "USTAWIENIA";
            btnUSTAWIENIA.UseVisualStyleBackColor = true;
            btnUSTAWIENIA.Click += btnUSTAWIENIA_Click;
            // 
            // btnKONIEC
            // 
            btnKONIEC.Location = new Point(99, 195);
            btnKONIEC.Name = "btnKONIEC";
            btnKONIEC.Size = new Size(128, 29);
            btnKONIEC.TabIndex = 2;
            btnKONIEC.Text = "KONIEC";
            btnKONIEC.UseVisualStyleBackColor = true;
            btnKONIEC.Click += btnKONIEC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 49);
            label1.Name = "label1";
            label1.Size = new Size(228, 29);
            label1.TabIndex = 3;
            label1.Text = "GDZIE JEST DYDELF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 254);
            Controls.Add(label1);
            Controls.Add(btnKONIEC);
            Controls.Add(btnUSTAWIENIA);
            Controls.Add(btnSTART);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSTART;
        private Button btnUSTAWIENIA;
        private Button btnKONIEC;
        private Label label1;
    }
}
