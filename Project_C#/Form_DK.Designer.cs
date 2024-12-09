namespace Project_C_
{
    partial class Form_DK
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
            label2 = new Label();
            label1 = new Label();
            txt_DKMK = new TextBox();
            txt_TK = new TextBox();
            btn_DangKy = new Button();
            label3 = new Label();
            label4 = new Label();
            txt_SDT = new TextBox();
            txt_DKTK = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 219);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 149);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 10;
            label1.Text = "Tài khoản:";
            // 
            // txt_DKMK
            // 
            txt_DKMK.Location = new Point(283, 212);
            txt_DKMK.Name = "txt_DKMK";
            txt_DKMK.Size = new Size(243, 27);
            txt_DKMK.TabIndex = 9;
            // 
            // txt_TK
            // 
            txt_TK.Location = new Point(283, 149);
            txt_TK.Name = "txt_TK";
            txt_TK.Size = new Size(243, 27);
            txt_TK.TabIndex = 8;
            // 
            // btn_DangKy
            // 
            btn_DangKy.BackColor = Color.FromArgb(255, 128, 0);
            btn_DangKy.FlatStyle = FlatStyle.Popup;
            btn_DangKy.ForeColor = Color.White;
            btn_DangKy.Location = new Point(305, 359);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(182, 49);
            btn_DangKy.TabIndex = 6;
            btn_DangKy.Text = "Đăng Ký";
            btn_DangKy.UseVisualStyleBackColor = false;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 285);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 17;
            label3.Text = "SĐT:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 149);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 16;
            label4.Text = "Tài khoản:";
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(283, 278);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(243, 27);
            txt_SDT.TabIndex = 15;
            // 
            // txt_DKTK
            // 
            txt_DKTK.Location = new Point(283, 149);
            txt_DKTK.Name = "txt_DKTK";
            txt_DKTK.Size = new Size(243, 27);
            txt_DKTK.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(237, 31);
            label5.Name = "label5";
            label5.Size = new Size(325, 38);
            label5.TabIndex = 18;
            label5.Text = "Đăng Ký Tài Khoản Mới";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(149, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 322);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // Form_DK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_SDT);
            Controls.Add(txt_DKTK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_DKMK);
            Controls.Add(txt_TK);
            Controls.Add(btn_DangKy);
            Controls.Add(panel1);
            Name = "Form_DK";
            Text = "Form_DK";
            Load += Form_DK_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_DKMK;
        private TextBox txt_TK;
        private Button btn_DangKy;
        private Label label3;
        private Label label4;
        private TextBox txt_SDT;
        private TextBox txt_DKTK;
        private Label label5;
        private Panel panel1;
    }
}