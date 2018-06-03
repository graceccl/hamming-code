namespace hamming1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSet = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonEn = new System.Windows.Forms.Button();
            this.radioButtonOddEn = new System.Windows.Forms.RadioButton();
            this.radioButtonEvenEn = new System.Windows.Forms.RadioButton();
            this.labelHam = new System.Windows.Forms.Label();
            this.labelInfoOut = new System.Windows.Forms.Label();
            this.textBoxHam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonEvenDe = new System.Windows.Forms.RadioButton();
            this.labelWrongbit = new System.Windows.Forms.Label();
            this.radioButtonOddDe = new System.Windows.Forms.RadioButton();
            this.labelCH = new System.Windows.Forms.Label();
            this.buttonDe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSet.Location = new System.Drawing.Point(16, 76);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(213, 29);
            this.labelSet.TabIndex = 0;
            this.labelSet.Text = "Set Hamming code : ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(16, 36);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(186, 29);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Information bits : ";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(221, 37);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(262, 36);
            this.textBoxInfo.TabIndex = 2;
            this.textBoxInfo.Text = "1101101011";
            // 
            // buttonEn
            // 
            this.buttonEn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEn.Location = new System.Drawing.Point(316, 205);
            this.buttonEn.Name = "buttonEn";
            this.buttonEn.Size = new System.Drawing.Size(167, 33);
            this.buttonEn.TabIndex = 3;
            this.buttonEn.Text = "Enter";
            this.buttonEn.UseVisualStyleBackColor = true;
            this.buttonEn.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // radioButtonOddEn
            // 
            this.radioButtonOddEn.AutoSize = true;
            this.radioButtonOddEn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOddEn.Location = new System.Drawing.Point(21, 205);
            this.radioButtonOddEn.Name = "radioButtonOddEn";
            this.radioButtonOddEn.Size = new System.Drawing.Size(139, 33);
            this.radioButtonOddEn.TabIndex = 4;
            this.radioButtonOddEn.Text = "Odd parity";
            this.radioButtonOddEn.UseVisualStyleBackColor = true;
            // 
            // radioButtonEvenEn
            // 
            this.radioButtonEvenEn.AutoSize = true;
            this.radioButtonEvenEn.Checked = true;
            this.radioButtonEvenEn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEvenEn.Location = new System.Drawing.Point(166, 205);
            this.radioButtonEvenEn.Name = "radioButtonEvenEn";
            this.radioButtonEvenEn.Size = new System.Drawing.Size(144, 33);
            this.radioButtonEvenEn.TabIndex = 5;
            this.radioButtonEvenEn.TabStop = true;
            this.radioButtonEvenEn.Text = "Even parity";
            this.radioButtonEvenEn.UseVisualStyleBackColor = true;
            // 
            // labelHam
            // 
            this.labelHam.AutoSize = true;
            this.labelHam.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHam.Location = new System.Drawing.Point(15, 33);
            this.labelHam.Name = "labelHam";
            this.labelHam.Size = new System.Drawing.Size(177, 29);
            this.labelHam.TabIndex = 7;
            this.labelHam.Text = "Hamming code : ";
            // 
            // labelInfoOut
            // 
            this.labelInfoOut.AutoSize = true;
            this.labelInfoOut.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoOut.Location = new System.Drawing.Point(15, 162);
            this.labelInfoOut.Name = "labelInfoOut";
            this.labelInfoOut.Size = new System.Drawing.Size(186, 29);
            this.labelInfoOut.TabIndex = 6;
            this.labelInfoOut.Text = "Information bits : ";
            // 
            // textBoxHam
            // 
            this.textBoxHam.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHam.Location = new System.Drawing.Point(214, 33);
            this.textBoxHam.Name = "textBoxHam";
            this.textBoxHam.Size = new System.Drawing.Size(283, 36);
            this.textBoxHam.TabIndex = 8;
            this.textBoxHam.Text = "1001000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelInfo);
            this.groupBox1.Controls.Add(this.labelSet);
            this.groupBox1.Controls.Add(this.radioButtonEvenEn);
            this.groupBox1.Controls.Add(this.textBoxInfo);
            this.groupBox1.Controls.Add(this.radioButtonOddEn);
            this.groupBox1.Controls.Add(this.buttonEn);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonEvenDe);
            this.groupBox2.Controls.Add(this.labelWrongbit);
            this.groupBox2.Controls.Add(this.radioButtonOddDe);
            this.groupBox2.Controls.Add(this.labelCH);
            this.groupBox2.Controls.Add(this.buttonDe);
            this.groupBox2.Controls.Add(this.labelHam);
            this.groupBox2.Controls.Add(this.labelInfoOut);
            this.groupBox2.Controls.Add(this.textBoxHam);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(507, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 250);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decode";
            // 
            // radioButtonEvenDe
            // 
            this.radioButtonEvenDe.AutoSize = true;
            this.radioButtonEvenDe.Checked = true;
            this.radioButtonEvenDe.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEvenDe.Location = new System.Drawing.Point(165, 205);
            this.radioButtonEvenDe.Name = "radioButtonEvenDe";
            this.radioButtonEvenDe.Size = new System.Drawing.Size(144, 33);
            this.radioButtonEvenDe.TabIndex = 8;
            this.radioButtonEvenDe.TabStop = true;
            this.radioButtonEvenDe.Text = "Even parity";
            this.radioButtonEvenDe.UseVisualStyleBackColor = true;
            // 
            // labelWrongbit
            // 
            this.labelWrongbit.AutoSize = true;
            this.labelWrongbit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrongbit.Location = new System.Drawing.Point(15, 76);
            this.labelWrongbit.Name = "labelWrongbit";
            this.labelWrongbit.Size = new System.Drawing.Size(126, 29);
            this.labelWrongbit.TabIndex = 10;
            this.labelWrongbit.Text = "Wrong bit : ";
            // 
            // radioButtonOddDe
            // 
            this.radioButtonOddDe.AutoSize = true;
            this.radioButtonOddDe.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOddDe.Location = new System.Drawing.Point(20, 205);
            this.radioButtonOddDe.Name = "radioButtonOddDe";
            this.radioButtonOddDe.Size = new System.Drawing.Size(139, 33);
            this.radioButtonOddDe.TabIndex = 7;
            this.radioButtonOddDe.Text = "Odd parity";
            this.radioButtonOddDe.UseVisualStyleBackColor = true;
            // 
            // labelCH
            // 
            this.labelCH.AutoSize = true;
            this.labelCH.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCH.Location = new System.Drawing.Point(15, 119);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(254, 29);
            this.labelCH.TabIndex = 9;
            this.labelCH.Text = "Correct Hamming code : ";
            // 
            // buttonDe
            // 
            this.buttonDe.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDe.Location = new System.Drawing.Point(323, 205);
            this.buttonDe.Name = "buttonDe";
            this.buttonDe.Size = new System.Drawing.Size(174, 33);
            this.buttonDe.TabIndex = 6;
            this.buttonDe.Text = "Enter";
            this.buttonDe.UseVisualStyleBackColor = true;
            this.buttonDe.Click += new System.EventHandler(this.buttonDe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hamming Code / by Chia-Ching Lee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSet;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonEn;
        private System.Windows.Forms.RadioButton radioButtonOddEn;
        private System.Windows.Forms.RadioButton radioButtonEvenEn;
        private System.Windows.Forms.Label labelHam;
        private System.Windows.Forms.Label labelInfoOut;
        private System.Windows.Forms.TextBox textBoxHam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.Label labelWrongbit;
        private System.Windows.Forms.RadioButton radioButtonEvenDe;
        private System.Windows.Forms.RadioButton radioButtonOddDe;
        private System.Windows.Forms.Button buttonDe;
    }
}

