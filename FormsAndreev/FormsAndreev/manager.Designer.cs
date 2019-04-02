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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvIzdelia = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvZakazy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdelia)).BeginInit();
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
            this.dgvZakazy.Controls.Add(this.tabPage1);
            this.dgvZakazy.Controls.Add(this.tabPage2);
            this.dgvZakazy.Location = new System.Drawing.Point(12, 30);
            this.dgvZakazy.Name = "dgvZakazy";
            this.dgvZakazy.SelectedIndex = 0;
            this.dgvZakazy.Size = new System.Drawing.Size(376, 262);
            this.dgvZakazy.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgvIzdelia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список изделий";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvIzdelia
            // 
            this.dgvIzdelia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdelia.Location = new System.Drawing.Point(6, 6);
            this.dgvIzdelia.Name = "dgvIzdelia";
            this.dgvIzdelia.Size = new System.Drawing.Size(356, 185);
            this.dgvIzdelia.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 319);
            this.Controls.Add(this.dgvZakazy);
            this.Controls.Add(this.WindowManager);
            this.Name = "manager";
            this.Text = "manager";
            this.dgvZakazy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdelia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WindowManager;
        private System.Windows.Forms.TabControl dgvZakazy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvIzdelia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}