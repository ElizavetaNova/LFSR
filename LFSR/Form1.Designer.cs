
namespace LFSR
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
            this.EncryptionBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultE = new System.Windows.Forms.TextBox();
            this.ZE = new System.Windows.Forms.TextBox();
            this.textBoxCoefficientVectorE = new System.Windows.Forms.TextBox();
            this.textBoxInitializationVectorE = new System.Windows.Forms.TextBox();
            this.textBoxOriginalMessageE = new System.Windows.Forms.TextBox();
            this.DecryptionBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ResultD = new System.Windows.Forms.TextBox();
            this.ZD = new System.Windows.Forms.TextBox();
            this.textBoxCoefficientVectorD = new System.Windows.Forms.TextBox();
            this.textBoxInitializationVectorD = new System.Windows.Forms.TextBox();
            this.textBoxСryptogramD = new System.Windows.Forms.TextBox();
            this.EncryptionBox.SuspendLayout();
            this.DecryptionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptionBox
            // 
            this.EncryptionBox.Controls.Add(this.button1);
            this.EncryptionBox.Controls.Add(this.label5);
            this.EncryptionBox.Controls.Add(this.label4);
            this.EncryptionBox.Controls.Add(this.label3);
            this.EncryptionBox.Controls.Add(this.label2);
            this.EncryptionBox.Controls.Add(this.label1);
            this.EncryptionBox.Controls.Add(this.ResultE);
            this.EncryptionBox.Controls.Add(this.ZE);
            this.EncryptionBox.Controls.Add(this.textBoxCoefficientVectorE);
            this.EncryptionBox.Controls.Add(this.textBoxInitializationVectorE);
            this.EncryptionBox.Controls.Add(this.textBoxOriginalMessageE);
            this.EncryptionBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EncryptionBox.Location = new System.Drawing.Point(12, 12);
            this.EncryptionBox.Name = "EncryptionBox";
            this.EncryptionBox.Size = new System.Drawing.Size(776, 205);
            this.EncryptionBox.TabIndex = 0;
            this.EncryptionBox.TabStop = false;
            this.EncryptionBox.Text = "Зашифрование";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Encryption);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вектор инициализации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вектор коэффициентов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходное сообщение";
            // 
            // ResultE
            // 
            this.ResultE.Location = new System.Drawing.Point(518, 172);
            this.ResultE.Name = "ResultE";
            this.ResultE.Size = new System.Drawing.Size(252, 27);
            this.ResultE.TabIndex = 4;
            // 
            // ZE
            // 
            this.ZE.Location = new System.Drawing.Point(518, 139);
            this.ZE.Name = "ZE";
            this.ZE.Size = new System.Drawing.Size(252, 27);
            this.ZE.TabIndex = 3;
            // 
            // textBoxCoefficientVectorE
            // 
            this.textBoxCoefficientVectorE.Location = new System.Drawing.Point(178, 60);
            this.textBoxCoefficientVectorE.Name = "textBoxCoefficientVectorE";
            this.textBoxCoefficientVectorE.Size = new System.Drawing.Size(252, 27);
            this.textBoxCoefficientVectorE.TabIndex = 2;
            // 
            // textBoxInitializationVectorE
            // 
            this.textBoxInitializationVectorE.Location = new System.Drawing.Point(178, 93);
            this.textBoxInitializationVectorE.Name = "textBoxInitializationVectorE";
            this.textBoxInitializationVectorE.Size = new System.Drawing.Size(252, 27);
            this.textBoxInitializationVectorE.TabIndex = 1;
            // 
            // textBoxOriginalMessageE
            // 
            this.textBoxOriginalMessageE.Location = new System.Drawing.Point(178, 27);
            this.textBoxOriginalMessageE.Name = "textBoxOriginalMessageE";
            this.textBoxOriginalMessageE.Size = new System.Drawing.Size(252, 27);
            this.textBoxOriginalMessageE.TabIndex = 0;
            // 
            // DecryptionBox
            // 
            this.DecryptionBox.Controls.Add(this.button2);
            this.DecryptionBox.Controls.Add(this.label6);
            this.DecryptionBox.Controls.Add(this.label7);
            this.DecryptionBox.Controls.Add(this.label8);
            this.DecryptionBox.Controls.Add(this.label9);
            this.DecryptionBox.Controls.Add(this.label10);
            this.DecryptionBox.Controls.Add(this.ResultD);
            this.DecryptionBox.Controls.Add(this.ZD);
            this.DecryptionBox.Controls.Add(this.textBoxCoefficientVectorD);
            this.DecryptionBox.Controls.Add(this.textBoxInitializationVectorD);
            this.DecryptionBox.Controls.Add(this.textBoxСryptogramD);
            this.DecryptionBox.Location = new System.Drawing.Point(12, 236);
            this.DecryptionBox.Name = "DecryptionBox";
            this.DecryptionBox.Size = new System.Drawing.Size(776, 202);
            this.DecryptionBox.TabIndex = 1;
            this.DecryptionBox.TabStop = false;
            this.DecryptionBox.Text = "Расшифрование";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Decryption);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Результат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Вектор инициализации";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Вектор коэффициентов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Шифрограмма";
            // 
            // ResultD
            // 
            this.ResultD.Location = new System.Drawing.Point(518, 167);
            this.ResultD.Name = "ResultD";
            this.ResultD.Size = new System.Drawing.Size(252, 27);
            this.ResultD.TabIndex = 14;
            // 
            // ZD
            // 
            this.ZD.Location = new System.Drawing.Point(518, 134);
            this.ZD.Name = "ZD";
            this.ZD.Size = new System.Drawing.Size(252, 27);
            this.ZD.TabIndex = 13;
            // 
            // textBoxCoefficientVectorD
            // 
            this.textBoxCoefficientVectorD.Location = new System.Drawing.Point(178, 62);
            this.textBoxCoefficientVectorD.Name = "textBoxCoefficientVectorD";
            this.textBoxCoefficientVectorD.Size = new System.Drawing.Size(252, 27);
            this.textBoxCoefficientVectorD.TabIndex = 12;
            // 
            // textBoxInitializationVectorD
            // 
            this.textBoxInitializationVectorD.Location = new System.Drawing.Point(178, 95);
            this.textBoxInitializationVectorD.Name = "textBoxInitializationVectorD";
            this.textBoxInitializationVectorD.Size = new System.Drawing.Size(252, 27);
            this.textBoxInitializationVectorD.TabIndex = 11;
            // 
            // textBoxСryptogramD
            // 
            this.textBoxСryptogramD.Location = new System.Drawing.Point(178, 29);
            this.textBoxСryptogramD.Name = "textBoxСryptogramD";
            this.textBoxСryptogramD.Size = new System.Drawing.Size(252, 27);
            this.textBoxСryptogramD.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecryptionBox);
            this.Controls.Add(this.EncryptionBox);
            this.Name = "Form1";
            this.Text = "LFSR";
            this.EncryptionBox.ResumeLayout(false);
            this.EncryptionBox.PerformLayout();
            this.DecryptionBox.ResumeLayout(false);
            this.DecryptionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EncryptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultE;
        private System.Windows.Forms.TextBox ZE;
        private System.Windows.Forms.TextBox textBoxCoefficientVectorE;
        private System.Windows.Forms.TextBox textBoxInitializationVectorE;
        private System.Windows.Forms.TextBox textBoxOriginalMessageE;
        private System.Windows.Forms.GroupBox DecryptionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ResultD;
        private System.Windows.Forms.TextBox ZD;
        private System.Windows.Forms.TextBox textBoxCoefficientVectorD;
        private System.Windows.Forms.TextBox textBoxInitializationVectorD;
        private System.Windows.Forms.TextBox textBoxСryptogramD;
    }
}

