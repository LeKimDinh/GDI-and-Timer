namespace Bài_Tập_Paint
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnArc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKieuVe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColorBrush = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDoDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoDay = new System.Windows.Forms.TextBox();
            this.btnColorPen = new System.Windows.Forms.Button();
            this.btnDuongThang = new System.Windows.Forms.Button();
            this.btnKhungHCN = new System.Windows.Forms.Button();
            this.btnHCN = new System.Windows.Forms.Button();
            this.btnKhungEllipse = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.btnSquare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Blue;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlMain.Location = new System.Drawing.Point(161, -1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(729, 517);
            this.pnlMain.TabIndex = 5;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnArc);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbKieuVe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnColorBrush);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbDoDay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDoDay);
            this.panel1.Controls.Add(this.btnColorPen);
            this.panel1.Controls.Add(this.btnDuongThang);
            this.panel1.Controls.Add(this.btnKhungHCN);
            this.panel1.Controls.Add(this.btnHCN);
            this.panel1.Controls.Add(this.btnKhungEllipse);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 517);
            this.panel1.TabIndex = 7;
            // 
            // btnArc
            // 
            this.btnArc.Location = new System.Drawing.Point(85, 401);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(61, 49);
            this.btnArc.TabIndex = 43;
            this.btnArc.Text = "Đường cong";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 18);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 214);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kiểu đường tô";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Màu đường tô";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbKieuVe
            // 
            this.cbKieuVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKieuVe.FormattingEnabled = true;
            this.cbKieuVe.Items.AddRange(new object[] {
            "Custom",
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot",
            "Solid"});
            this.cbKieuVe.Location = new System.Drawing.Point(63, 86);
            this.cbKieuVe.Margin = new System.Windows.Forms.Padding(2);
            this.cbKieuVe.Name = "cbKieuVe";
            this.cbKieuVe.Size = new System.Drawing.Size(95, 21);
            this.cbKieuVe.TabIndex = 37;
            this.cbKieuVe.SelectedIndexChanged += new System.EventHandler(this.cbKieuVe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kiểu vẽ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kiểu vẽ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnColorBrush
            // 
            this.btnColorBrush.Location = new System.Drawing.Point(6, 124);
            this.btnColorBrush.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorBrush.Name = "btnColorBrush";
            this.btnColorBrush.Size = new System.Drawing.Size(149, 18);
            this.btnColorBrush.TabIndex = 34;
            this.btnColorBrush.UseVisualStyleBackColor = true;
            this.btnColorBrush.Click += new System.EventHandler(this.btnColorBrush_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Màu nền tô";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbDoDay
            // 
            this.lbDoDay.AutoSize = true;
            this.lbDoDay.Location = new System.Drawing.Point(6, 4);
            this.lbDoDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoDay.Name = "lbDoDay";
            this.lbDoDay.Size = new System.Drawing.Size(44, 13);
            this.lbDoDay.TabIndex = 31;
            this.lbDoDay.Text = "Độ dày:\r\n";
            this.lbDoDay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Màu sắc bút:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtDoDay
            // 
            this.txtDoDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoDay.Location = new System.Drawing.Point(6, 19);
            this.txtDoDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoDay.Name = "txtDoDay";
            this.txtDoDay.Size = new System.Drawing.Size(150, 20);
            this.txtDoDay.TabIndex = 29;
            this.txtDoDay.Text = "4";
            // 
            // btnColorPen
            // 
            this.btnColorPen.Location = new System.Drawing.Point(6, 60);
            this.btnColorPen.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorPen.Name = "btnColorPen";
            this.btnColorPen.Size = new System.Drawing.Size(149, 18);
            this.btnColorPen.TabIndex = 30;
            this.btnColorPen.UseVisualStyleBackColor = true;
            this.btnColorPen.Click += new System.EventHandler(this.btnColorPen_Click);
            // 
            // btnDuongThang
            // 
            this.btnDuongThang.Location = new System.Drawing.Point(6, 266);
            this.btnDuongThang.Name = "btnDuongThang";
            this.btnDuongThang.Size = new System.Drawing.Size(61, 55);
            this.btnDuongThang.TabIndex = 24;
            this.btnDuongThang.Text = "Đường Thẳng";
            this.btnDuongThang.UseVisualStyleBackColor = true;
            this.btnDuongThang.Click += new System.EventHandler(this.btnDuongThang_Click);
            // 
            // btnKhungHCN
            // 
            this.btnKhungHCN.Location = new System.Drawing.Point(85, 266);
            this.btnKhungHCN.Name = "btnKhungHCN";
            this.btnKhungHCN.Size = new System.Drawing.Size(61, 55);
            this.btnKhungHCN.TabIndex = 25;
            this.btnKhungHCN.Text = "Hình Chũ Nhật";
            this.btnKhungHCN.UseVisualStyleBackColor = true;
            this.btnKhungHCN.Click += new System.EventHandler(this.btnKhungHCN_Click);
            // 
            // btnHCN
            // 
            this.btnHCN.Location = new System.Drawing.Point(85, 335);
            this.btnHCN.Name = "btnHCN";
            this.btnHCN.Size = new System.Drawing.Size(61, 49);
            this.btnHCN.TabIndex = 26;
            this.btnHCN.Text = "Khung Hình Chữ Nhật";
            this.btnHCN.UseVisualStyleBackColor = true;
            this.btnHCN.Click += new System.EventHandler(this.btnHCN_Click);
            // 
            // btnKhungEllipse
            // 
            this.btnKhungEllipse.Location = new System.Drawing.Point(9, 335);
            this.btnKhungEllipse.Name = "btnKhungEllipse";
            this.btnKhungEllipse.Size = new System.Drawing.Size(61, 49);
            this.btnKhungEllipse.TabIndex = 27;
            this.btnKhungEllipse.Text = "Hình Ellipse";
            this.btnKhungEllipse.UseVisualStyleBackColor = true;
            this.btnKhungEllipse.Click += new System.EventHandler(this.btnKhungEllipse_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(9, 401);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(61, 49);
            this.btnEllipse.TabIndex = 28;
            this.btnEllipse.Text = "Khung hình Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.Blue;
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(6, 465);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(61, 49);
            this.btnSquare.TabIndex = 44;
            this.btnSquare.Text = "Hình vuông";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColorBrush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDoDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoDay;
        private System.Windows.Forms.Button btnColorPen;
        private System.Windows.Forms.Button btnDuongThang;
        private System.Windows.Forms.Button btnKhungHCN;
        private System.Windows.Forms.Button btnHCN;
        private System.Windows.Forms.Button btnKhungEllipse;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKieuVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btnSquare;
    }
}

