namespace WinFormsMethod
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtxName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnBMI = new Button();
            lblResult = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 65);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 239);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 1;
            label2.Text = "ส่วนสูง(cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 304);
            label3.Name = "label3";
            label3.Size = new Size(137, 37);
            label3.TabIndex = 2;
            label3.Text = "น้ำหนัก(kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 115);
            label4.Name = "label4";
            label4.Size = new Size(146, 37);
            label4.TabIndex = 3;
            label4.Text = "ชื่อ-นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 178);
            label5.Name = "label5";
            label5.Size = new Size(57, 37);
            label5.TabIndex = 4;
            label5.Text = "อายุ";
            // 
            // txtxName
            // 
            txtxName.Location = new Point(277, 112);
            txtxName.Multiline = true;
            txtxName.Name = "txtxName";
            txtxName.Size = new Size(457, 40);
            txtxName.TabIndex = 1;
            txtxName.TextChanged += txtxName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(277, 178);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(229, 38);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(277, 239);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(229, 37);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(277, 304);
            txtWeight.Multiline = true;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(229, 37);
            txtWeight.TabIndex = 4;
            // 
            // btnBMI
            // 
            btnBMI.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBMI.Location = new Point(844, 48);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(231, 135);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่าBMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(255, 192, 192);
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(141, 381);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(906, 310);
            lblResult.TabIndex = 10;
            lblResult.Text = "xxxxxxxxxxxx";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(832, 239);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(265, 104);
            btnClear.TabIndex = 11;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 727);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnBMI);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtxName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnBMI;
        private Label lblResult;
        private Button btnClear;
    }
}
