namespace AracSimulasyonuApp
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
            cmbAraclar = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtGunSayisi = new TextBox();
            btnAracKirala = new Button();
            label3 = new Label();
            lblSonuc = new Label();
            lsbKiralananArac = new ListBox();
            SuspendLayout();
            // 
            // cmbAraclar
            // 
            cmbAraclar.FormattingEnabled = true;
            cmbAraclar.Location = new Point(104, 31);
            cmbAraclar.Name = "cmbAraclar";
            cmbAraclar.Size = new Size(468, 28);
            cmbAraclar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 39);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Araçlar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(11, 98);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Gün Sayısı";
            // 
            // txtGunSayisi
            // 
            txtGunSayisi.Location = new Point(104, 91);
            txtGunSayisi.Name = "txtGunSayisi";
            txtGunSayisi.Size = new Size(468, 27);
            txtGunSayisi.TabIndex = 3;
            // 
            // btnAracKirala
            // 
            btnAracKirala.Location = new Point(415, 144);
            btnAracKirala.Name = "btnAracKirala";
            btnAracKirala.Size = new Size(156, 37);
            btnAracKirala.TabIndex = 4;
            btnAracKirala.Text = "Kirala";
            btnAracKirala.UseVisualStyleBackColor = true;
            btnAracKirala.Click += btnAracKirala_Click;
            // 
            // label3
            // 
            label3.Location = new Point(11, 152);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Kiralama Ücreti";
            // 
            // lblSonuc
            // 
            lblSonuc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSonuc.Location = new Point(143, 152);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(93, 20);
            lblSonuc.TabIndex = 2;
            // 
            // lsbKiralananArac
            // 
            lsbKiralananArac.FormattingEnabled = true;
            lsbKiralananArac.Location = new Point(5, 188);
            lsbKiralananArac.Name = "lsbKiralananArac";
            lsbKiralananArac.Size = new Size(567, 144);
            lsbKiralananArac.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 347);
            Controls.Add(lsbKiralananArac);
            Controls.Add(label3);
            Controls.Add(btnAracKirala);
            Controls.Add(txtGunSayisi);
            Controls.Add(label2);
            Controls.Add(lblSonuc);
            Controls.Add(label1);
            Controls.Add(cmbAraclar);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAraclar;
        private Label label1;
        private Label label2;
        private TextBox txtGunSayisi;
        private Button btnAracKirala;
        private Label label3;
        private Label lblSonuc;
        private ListBox lsbKiralananArac;
    }
}
