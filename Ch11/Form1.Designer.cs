﻿namespace Ch11
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
        protected override void Dispose(bool disposing) // 폼 디자인 모드 // 직접 건들일은 없다.
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.btnUid = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnname = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Hp = new System.Windows.Forms.Label();
            this.btnHp = new System.Windows.Forms.Button();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.lbUid = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbHp = new System.Windows.Forms.Label();
            this.chkFruit1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkFruit2 = new System.Windows.Forms.CheckBox();
            this.chkFruit3 = new System.Windows.Forms.CheckBox();
            this.chkFruit4 = new System.Windows.Forms.CheckBox();
            this.chkFruit5 = new System.Windows.Forms.CheckBox();
            this.btnchkFruit = new System.Windows.Forms.Button();
            this.btnChkColor = new System.Windows.Forms.Button();
            this.chkColor5 = new System.Windows.Forms.CheckBox();
            this.chkColor4 = new System.Windows.Forms.CheckBox();
            this.chkColor3 = new System.Windows.Forms.CheckBox();
            this.chkColor2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkColor1 = new System.Windows.Forms.CheckBox();
            this.lbFruitResult = new System.Windows.Forms.Label();
            this.lbColorResult = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello WinForm!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Button 컨트롤 실습";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(41, 51);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(91, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "버튼";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(138, 51);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(91, 23);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "버튼2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Image = global::Ch11.Properties.Resources.images;
            this.btn3.Location = new System.Drawing.Point(302, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(193, 210);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "버튼3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "TextBox 컨트롤 실습";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(64, 127);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 23);
            this.txtUid.TabIndex = 7;
            this.txtUid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUid
            // 
            this.btnUid.Location = new System.Drawing.Point(170, 127);
            this.btnUid.Name = "btnUid";
            this.btnUid.Size = new System.Drawing.Size(82, 23);
            this.btnUid.TabIndex = 8;
            this.btnUid.Text = "확인";
            this.btnUid.UseVisualStyleBackColor = true;
            this.btnUid.Click += new System.EventHandler(this.btnUid_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "아이디 :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "이름 :";
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(170, 169);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(82, 23);
            this.btnname.TabIndex = 11;
            this.btnname.Text = "확인";
            this.btnname.UseVisualStyleBackColor = true;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 169);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Hp
            // 
            this.Hp.AutoSize = true;
            this.Hp.Location = new System.Drawing.Point(8, 215);
            this.Hp.Name = "Hp";
            this.Hp.Size = new System.Drawing.Size(50, 15);
            this.Hp.TabIndex = 15;
            this.Hp.Text = "휴대폰 :";
            // 
            // btnHp
            // 
            this.btnHp.Location = new System.Drawing.Point(170, 212);
            this.btnHp.Name = "btnHp";
            this.btnHp.Size = new System.Drawing.Size(82, 23);
            this.btnHp.TabIndex = 14;
            this.btnHp.Text = "확인";
            this.btnHp.UseVisualStyleBackColor = true;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(64, 212);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(100, 23);
            this.txtHp.TabIndex = 13;
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Location = new System.Drawing.Point(258, 131);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(38, 15);
            this.lbUid.TabIndex = 16;
            this.lbUid.Text = "결과 :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(258, 173);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 15);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "결과 :";
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Location = new System.Drawing.Point(258, 216);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(38, 15);
            this.lbHp.TabIndex = 18;
            this.lbHp.Text = "결과 :";
            // 
            // chkFruit1
            // 
            this.chkFruit1.AutoSize = true;
            this.chkFruit1.Location = new System.Drawing.Point(12, 289);
            this.chkFruit1.Name = "chkFruit1";
            this.chkFruit1.Size = new System.Drawing.Size(50, 19);
            this.chkFruit1.TabIndex = 19;
            this.chkFruit1.Text = "사과";
            this.chkFruit1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "CheckBox 컨트롤 실습";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "좋아하는 과일 선택";
            // 
            // chkFruit2
            // 
            this.chkFruit2.AutoSize = true;
            this.chkFruit2.Location = new System.Drawing.Point(68, 289);
            this.chkFruit2.Name = "chkFruit2";
            this.chkFruit2.Size = new System.Drawing.Size(50, 19);
            this.chkFruit2.TabIndex = 22;
            this.chkFruit2.Text = "딸기";
            this.chkFruit2.UseVisualStyleBackColor = true;
            // 
            // chkFruit3
            // 
            this.chkFruit3.AutoSize = true;
            this.chkFruit3.Location = new System.Drawing.Point(124, 289);
            this.chkFruit3.Name = "chkFruit3";
            this.chkFruit3.Size = new System.Drawing.Size(50, 19);
            this.chkFruit3.TabIndex = 23;
            this.chkFruit3.Text = "포도";
            this.chkFruit3.UseVisualStyleBackColor = true;
            // 
            // chkFruit4
            // 
            this.chkFruit4.AutoSize = true;
            this.chkFruit4.Location = new System.Drawing.Point(180, 289);
            this.chkFruit4.Name = "chkFruit4";
            this.chkFruit4.Size = new System.Drawing.Size(50, 19);
            this.chkFruit4.TabIndex = 24;
            this.chkFruit4.Text = "수박";
            this.chkFruit4.UseVisualStyleBackColor = true;
            // 
            // chkFruit5
            // 
            this.chkFruit5.AutoSize = true;
            this.chkFruit5.Location = new System.Drawing.Point(236, 289);
            this.chkFruit5.Name = "chkFruit5";
            this.chkFruit5.Size = new System.Drawing.Size(50, 19);
            this.chkFruit5.TabIndex = 25;
            this.chkFruit5.Text = "참외";
            this.chkFruit5.UseVisualStyleBackColor = true;
            // 
            // btnchkFruit
            // 
            this.btnchkFruit.Location = new System.Drawing.Point(292, 286);
            this.btnchkFruit.Name = "btnchkFruit";
            this.btnchkFruit.Size = new System.Drawing.Size(75, 23);
            this.btnchkFruit.TabIndex = 26;
            this.btnchkFruit.Text = "확인";
            this.btnchkFruit.UseVisualStyleBackColor = true;
            this.btnchkFruit.Click += new System.EventHandler(this.btnchkFruit_Click);
            // 
            // btnChkColor
            // 
            this.btnChkColor.Location = new System.Drawing.Point(292, 377);
            this.btnChkColor.Name = "btnChkColor";
            this.btnChkColor.Size = new System.Drawing.Size(75, 23);
            this.btnChkColor.TabIndex = 33;
            this.btnChkColor.Text = "확인";
            this.btnChkColor.UseVisualStyleBackColor = true;
            this.btnChkColor.Click += new System.EventHandler(this.btnChkColor_Click);
            // 
            // chkColor5
            // 
            this.chkColor5.AutoSize = true;
            this.chkColor5.Location = new System.Drawing.Point(236, 380);
            this.chkColor5.Name = "chkColor5";
            this.chkColor5.Size = new System.Drawing.Size(50, 19);
            this.chkColor5.TabIndex = 32;
            this.chkColor5.Text = "검정";
            this.chkColor5.UseVisualStyleBackColor = true;
            // 
            // chkColor4
            // 
            this.chkColor4.AutoSize = true;
            this.chkColor4.Location = new System.Drawing.Point(180, 380);
            this.chkColor4.Name = "chkColor4";
            this.chkColor4.Size = new System.Drawing.Size(50, 19);
            this.chkColor4.TabIndex = 31;
            this.chkColor4.Text = "노랑";
            this.chkColor4.UseVisualStyleBackColor = true;
            // 
            // chkColor3
            // 
            this.chkColor3.AutoSize = true;
            this.chkColor3.Location = new System.Drawing.Point(124, 380);
            this.chkColor3.Name = "chkColor3";
            this.chkColor3.Size = new System.Drawing.Size(50, 19);
            this.chkColor3.TabIndex = 30;
            this.chkColor3.Text = "녹색";
            this.chkColor3.UseVisualStyleBackColor = true;
            // 
            // chkColor2
            // 
            this.chkColor2.AutoSize = true;
            this.chkColor2.Location = new System.Drawing.Point(68, 380);
            this.chkColor2.Name = "chkColor2";
            this.chkColor2.Size = new System.Drawing.Size(50, 19);
            this.chkColor2.TabIndex = 29;
            this.chkColor2.Text = "파랑";
            this.chkColor2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "좋아하는 색을 모두 선택하세요.";
            // 
            // chkColor1
            // 
            this.chkColor1.AutoSize = true;
            this.chkColor1.Location = new System.Drawing.Point(12, 380);
            this.chkColor1.Name = "chkColor1";
            this.chkColor1.Size = new System.Drawing.Size(50, 19);
            this.chkColor1.TabIndex = 27;
            this.chkColor1.Text = "빨강";
            this.chkColor1.UseVisualStyleBackColor = true;
            // 
            // lbFruitResult
            // 
            this.lbFruitResult.AutoSize = true;
            this.lbFruitResult.Location = new System.Drawing.Point(12, 326);
            this.lbFruitResult.Name = "lbFruitResult";
            this.lbFruitResult.Size = new System.Drawing.Size(42, 15);
            this.lbFruitResult.TabIndex = 34;
            this.lbFruitResult.Text = "결과 : ";
            // 
            // lbColorResult
            // 
            this.lbColorResult.AutoSize = true;
            this.lbColorResult.Location = new System.Drawing.Point(12, 414);
            this.lbColorResult.Name = "lbColorResult";
            this.lbColorResult.Size = new System.Drawing.Size(42, 15);
            this.lbColorResult.TabIndex = 35;
            this.lbColorResult.Text = "결과 : ";
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(8, 491);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(115, 23);
            this.btnForm2.TabIndex = 36;
            this.btnForm2.Text = "Form2 띄우기";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(138, 491);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(115, 23);
            this.btnForm3.TabIndex = 37;
            this.btnForm3.Text = "Form3 띄우기";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "선택하세요!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 569);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.lbColorResult);
            this.Controls.Add(this.lbFruitResult);
            this.Controls.Add(this.btnChkColor);
            this.Controls.Add(this.chkColor5);
            this.Controls.Add(this.chkColor4);
            this.Controls.Add(this.chkColor3);
            this.Controls.Add(this.chkColor2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkColor1);
            this.Controls.Add(this.btnchkFruit);
            this.Controls.Add(this.chkFruit5);
            this.Controls.Add(this.chkFruit4);
            this.Controls.Add(this.chkFruit3);
            this.Controls.Add(this.chkFruit2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkFruit1);
            this.Controls.Add(this.lbHp);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbUid);
            this.Controls.Add(this.Hp);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUid);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label label3;
        private TextBox txtUid;
        private Button btnUid;
        private Label label4;
        private Label label5;
        private Button btnname;
        private TextBox txtName;
        private Label Hp;
        private Button btnHp;
        private TextBox txtHp;
        private Label lbUid;
        private Label lbName;
        private Label lbHp;
        private CheckBox chkFruit1;
        private Label label6;
        private Label label7;
        private CheckBox chkFruit2;
        private CheckBox chkFruit3;
        private CheckBox chkFruit4;
        private CheckBox chkFruit5;
        private Button btnchkFruit;
        private Button btnChkColor;
        private CheckBox chkColor5;
        private CheckBox chkColor4;
        private CheckBox chkColor3;
        private CheckBox chkColor2;
        private Label label8;
        private CheckBox chkColor1;
        private Label lbFruitResult;
        private Label lbColorResult;
        private Button btnForm2;
        private Button btnForm3;
        private Label label9;
    }
}