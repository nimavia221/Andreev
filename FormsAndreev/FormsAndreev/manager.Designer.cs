namespace FormsAndreev
{
    partial class manager
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
            this.WindowManager = new System.Windows.Forms.Label();
            this.dgvZakazy = new System.Windows.Forms.TabControl();
            this.tabIzd = new System.Windows.Forms.TabPage();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.dgvIzdelia = new System.Windows.Forms.DataGridView();
            this.tabZakaz = new System.Windows.Forms.TabPage();
            this.btnPokaz1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dgvZakazy.SuspendLayout();
            this.tabIzd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdelia)).BeginInit();
            this.tabZakaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowManager
            // 
            this.WindowManager.AutoSize = true;
            this.WindowManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WindowManager.Location = new System.Drawing.Point(12, 3);
            this.WindowManager.Name = "WindowManager";
            this.WindowManager.Size = new System.Drawing.Size(173, 24);
            this.WindowManager.TabIndex = 0;
            this.WindowManager.Text = "Экран менеджера";
            // 
            // dgvZakazy
            // 
            this.dgvZakazy.Controls.Add(this.tabIzd);
            this.dgvZakazy.Controls.Add(this.tabZakaz);
            this.dgvZakazy.Location = new System.Drawing.Point(12, 30);
            this.dgvZakazy.Name = "dgvZakazy";
            this.dgvZakazy.SelectedIndex = 0;
            this.dgvZakazy.Size = new System.Drawing.Size(970, 504);
            this.dgvZakazy.TabIndex = 1;
            // 
            // tabIzd
            // 
            this.tabIzd.Controls.Add(this.button1);
            this.tabIzd.Controls.Add(this.btnPokaz);
            this.tabIzd.Controls.Add(this.dgvIzdelia);
            this.tabIzd.Location = new System.Drawing.Point(4, 22);
            this.tabIzd.Name = "tabIzd";
            this.tabIzd.Padding = new System.Windows.Forms.Padding(3);
            this.tabIzd.Size = new System.Drawing.Size(962, 478);
            this.tabIzd.TabIndex = 0;
            this.tabIzd.Text = "Список изделий";
            this.tabIzd.UseVisualStyleBackColor = true;
            this.tabIzd.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnPokaz
            // 
            this.btnPokaz.Location = new System.Drawing.Point(6, 439);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(79, 33);
            this.btnPokaz.TabIndex = 1;
            this.btnPokaz.Text = "Отобразить";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvIzdelia
            // 
            this.dgvIzdelia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdelia.Location = new System.Drawing.Point(6, 6);
            this.dgvIzdelia.Name = "dgvIzdelia";
            this.dgvIzdelia.ReadOnly = true;
            this.dgvIzdelia.Size = new System.Drawing.Size(950, 185);
            this.dgvIzdelia.TabIndex = 0;
            // 
            // tabZakaz
            // 
            this.tabZakaz.Controls.Add(this.comboBox2);
            this.tabZakaz.Controls.Add(this.comboBox1);
            this.tabZakaz.Controls.Add(this.button2);
            this.tabZakaz.Controls.Add(this.btnPokaz1);
            this.tabZakaz.Controls.Add(this.dataGridView1);
            this.tabZakaz.Location = new System.Drawing.Point(4, 22);
            this.tabZakaz.Name = "tabZakaz";
            this.tabZakaz.Padding = new System.Windows.Forms.Padding(3);
            this.tabZakaz.Size = new System.Drawing.Size(962, 478);
            this.tabZakaz.TabIndex = 1;
            this.tabZakaz.Text = "Заказы";
            this.tabZakaz.UseVisualStyleBackColor = true;
            // 
            // btnPokaz1
            // 
            this.btnPokaz1.Location = new System.Drawing.Point(6, 198);
            this.btnPokaz1.Name = "btnPokaz1";
            this.btnPokaz1.Size = new System.Drawing.Size(84, 32);
            this.btnPokaz1.TabIndex = 1;
            this.btnPokaz1.Text = "Отобразить";
            this.btnPokaz1.UseVisualStyleBackColor = true;
            this.btnPokaz1.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Создать заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(321, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 649);
            this.Controls.Add(this.dgvZakazy);
            this.Controls.Add(this.WindowManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "manager";
            this.Text = "manager";
            this.Load += new System.EventHandler(this.manager_Load);
            this.dgvZakazy.ResumeLayout(false);
            this.tabIzd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdelia)).EndInit();
            this.tabZakaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WindowManager;
        private System.Windows.Forms.TabControl dgvZakazy;
        private System.Windows.Forms.TabPage tabIzd;
        private System.Windows.Forms.DataGridView dgvIzdelia;
        private System.Windows.Forms.TabPage tabZakaz;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.Button btnPokaz1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}