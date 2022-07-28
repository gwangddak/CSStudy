namespace Ch11
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCity1 = new System.Windows.Forms.Button();
            this.btCity2 = new System.Windows.Forms.Button();
            this.cbCity1 = new System.Windows.Forms.ComboBox();
            this.cbCity2 = new System.Windows.Forms.ComboBox();
            this.cbPos1 = new System.Windows.Forms.Label();
            this.cbPos2 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(12, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 1);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "계급";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "지역";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Ch11.Properties.Resources.다운로드__1_;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 166);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btCity1
            // 
            this.btCity1.Location = new System.Drawing.Point(233, 195);
            this.btCity1.Name = "btCity1";
            this.btCity1.Size = new System.Drawing.Size(55, 23);
            this.btCity1.TabIndex = 7;
            this.btCity1.Text = "button1";
            this.btCity1.UseVisualStyleBackColor = true;
            this.btCity1.Click += new System.EventHandler(this.btCity1_Click);
            // 
            // btCity2
            // 
            this.btCity2.Location = new System.Drawing.Point(233, 287);
            this.btCity2.Name = "btCity2";
            this.btCity2.Size = new System.Drawing.Size(55, 23);
            this.btCity2.TabIndex = 8;
            this.btCity2.Text = "button1";
            this.btCity2.UseVisualStyleBackColor = true;
            this.btCity2.Click += new System.EventHandler(this.btCity2_Click);
            // 
            // cbCity1
            // 
            this.cbCity1.FormattingEnabled = true;
            this.cbCity1.Location = new System.Drawing.Point(12, 195);
            this.cbCity1.Name = "cbCity1";
            this.cbCity1.Size = new System.Drawing.Size(215, 23);
            this.cbCity1.TabIndex = 9;
            this.cbCity1.SelectedIndexChanged += new System.EventHandler(this.cbCity1_SelectedIndexChanged);
            // 
            // cbCity2
            // 
            this.cbCity2.FormattingEnabled = true;
            this.cbCity2.Location = new System.Drawing.Point(12, 287);
            this.cbCity2.Name = "cbCity2";
            this.cbCity2.Size = new System.Drawing.Size(215, 23);
            this.cbCity2.TabIndex = 10;
            this.cbCity2.SelectedIndexChanged += new System.EventHandler(this.cbCity2_SelectedIndexChanged);
            // 
            // cbPos1
            // 
            this.cbPos1.AutoSize = true;
            this.cbPos1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbPos1.Location = new System.Drawing.Point(12, 229);
            this.cbPos1.Name = "cbPos1";
            this.cbPos1.Size = new System.Drawing.Size(31, 15);
            this.cbPos1.TabIndex = 11;
            this.cbPos1.Text = "결과";
            this.cbPos1.Click += new System.EventHandler(this.cbPos1_Click);
            // 
            // cbPos2
            // 
            this.cbPos2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbPos2.Location = new System.Drawing.Point(12, 320);
            this.cbPos2.Name = "cbPos2";
            this.cbPos2.Size = new System.Drawing.Size(39, 15);
            this.cbPos2.TabIndex = 12;
            this.cbPos2.Text = "결과";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 342);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(338, 164);
            this.gridView.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 518);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.cbPos2);
            this.Controls.Add(this.cbPos1);
            this.Controls.Add(this.cbCity2);
            this.Controls.Add(this.cbCity1);
            this.Controls.Add(this.btCity2);
            this.Controls.Add(this.btCity1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button btCity1;
        private Button btCity2;
        private ComboBox cbCity1;
        private ComboBox cbCity2;
        private Label cbPos1;
        private Label cbPos2;
        private DataGridView gridView;
    }
}