namespace Project_C_
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
            btn_DangKy = new Button();
            button2 = new Button();
            txt_TK = new TextBox();
            txt_MK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_DangKy
            // 
            btn_DangKy.Location = new Point(98, 336);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(130, 49);
            btn_DangKy.TabIndex = 0;
            btn_DangKy.Text = "Đăng Ký";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // button2
            // 
            button2.Location = new Point(314, 336);
            button2.Name = "button2";
            button2.Size = new Size(130, 49);
            button2.TabIndex = 1;
            button2.Text = "Đăng Nhập";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_TK
            // 
            txt_TK.Location = new Point(201, 117);
            txt_TK.Name = "txt_TK";
            txt_TK.Size = new Size(243, 27);
            txt_TK.TabIndex = 2;
            txt_TK.TextChanged += textBox1_TextChanged;
            // 
            // txt_MK
            // 
            txt_MK.Location = new Point(201, 231);
            txt_MK.Name = "txt_MK";
            txt_MK.Size = new Size(243, 27);
            txt_MK.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 117);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 238);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(151, 26);
            label5.Name = "label5";
            label5.Size = new Size(325, 38);
            label5.TabIndex = 19;
            label5.Text = "Đăng Ký Tài Khoản Mới";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 484);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_MK);
            Controls.Add(txt_TK);
            Controls.Add(button2);
            Controls.Add(btn_DangKy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DangKy;
        private Button button2;
        private TextBox txt_TK;
        private TextBox txt_MK;
        private Label label1;
        private Label label2;
        private Label label5;
    }
}
