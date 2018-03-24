﻿namespace UI
{
    partial class InHospitalInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboKeshi = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlou2 = new System.Windows.Forms.TextBox();
            this.txtlou1 = new System.Windows.Forms.TextBox();
            this.txtfang2 = new System.Windows.Forms.TextBox();
            this.txtfang1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBFnum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "病房房号：";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(152, 71);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(124, 21);
            this.txtnum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "病房类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "病房科室：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "病房价格：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(160, 358);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "普通病房",
            "重病房"});
            this.cboType.Location = new System.Drawing.Point(159, 274);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(124, 20);
            this.cboType.TabIndex = 2;
            // 
            // cboKeshi
            // 
            this.cboKeshi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKeshi.FormattingEnabled = true;
            this.cboKeshi.Location = new System.Drawing.Point(158, 231);
            this.cboKeshi.Name = "cboKeshi";
            this.cboKeshi.Size = new System.Drawing.Size(124, 20);
            this.cboKeshi.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(83, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "批量增加";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "单个添加:";
            // 
            // btnDel
            // 
            this.btnDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDel.Location = new System.Drawing.Point(205, 404);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 32);
            this.btnDel.TabIndex = 43;
            this.btnDel.Text = "清空";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(80, 404);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 32);
            this.btnYes.TabIndex = 42;
            this.btnYes.Text = "确定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "楼层";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "房号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "至";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 54;
            this.label9.Text = "至";
            // 
            // txtlou2
            // 
            this.txtlou2.Enabled = false;
            this.txtlou2.Location = new System.Drawing.Point(216, 143);
            this.txtlou2.MaxLength = 1;
            this.txtlou2.Name = "txtlou2";
            this.txtlou2.Size = new System.Drawing.Size(66, 21);
            this.txtlou2.TabIndex = 51;
            // 
            // txtlou1
            // 
            this.txtlou1.Enabled = false;
            this.txtlou1.Location = new System.Drawing.Point(120, 143);
            this.txtlou1.MaxLength = 1;
            this.txtlou1.Name = "txtlou1";
            this.txtlou1.Size = new System.Drawing.Size(66, 21);
            this.txtlou1.TabIndex = 50;
            // 
            // txtfang2
            // 
            this.txtfang2.Enabled = false;
            this.txtfang2.Location = new System.Drawing.Point(216, 190);
            this.txtfang2.MaxLength = 2;
            this.txtfang2.Name = "txtfang2";
            this.txtfang2.Size = new System.Drawing.Size(66, 21);
            this.txtfang2.TabIndex = 53;
            // 
            // txtfang1
            // 
            this.txtfang1.Enabled = false;
            this.txtfang1.Location = new System.Drawing.Point(120, 188);
            this.txtfang1.MaxLength = 1;
            this.txtfang1.Name = "txtfang1";
            this.txtfang1.Size = new System.Drawing.Size(66, 21);
            this.txtfang1.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 58;
            this.label10.Text = "病床个数:";
            // 
            // txtBFnum
            // 
            this.txtBFnum.Location = new System.Drawing.Point(157, 318);
            this.txtBFnum.Name = "txtBFnum";
            this.txtBFnum.Size = new System.Drawing.Size(124, 21);
            this.txtBFnum.TabIndex = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.txtBFnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.txtlou2);
            this.groupBox1.Controls.Add(this.cboKeshi);
            this.groupBox1.Controls.Add(this.txtlou1);
            this.groupBox1.Controls.Add(this.btnYes);
            this.groupBox1.Controls.Add(this.txtfang2);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.txtfang1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 524);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病房添加";
            // 
            // InHospitalInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 541);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InHospitalInsert";
            this.Text = "InHospitalInsert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InHospitalInsert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboKeshi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtlou2;
        private System.Windows.Forms.TextBox txtlou1;
        private System.Windows.Forms.TextBox txtfang2;
        private System.Windows.Forms.TextBox txtfang1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBFnum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}