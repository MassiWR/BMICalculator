namespace BMICalculator
{
    partial class MainForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtCmFt = new System.Windows.Forms.TextBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rBtnMetric = new System.Windows.Forms.RadioButton();
            this.rBtnImperial = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeightCat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpUnit.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(129, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 30);
            this.txtName.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.CausesValidation = false;
            this.lblHeight.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(31, 81);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(119, 24);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            this.lblHeight.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCmFt
            // 
            this.txtCmFt.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmFt.Location = new System.Drawing.Point(129, 81);
            this.txtCmFt.Name = "txtCmFt";
            this.txtCmFt.Size = new System.Drawing.Size(58, 30);
            this.txtCmFt.TabIndex = 3;
            // 
            // txtInch
            // 
            this.txtInch.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInch.Location = new System.Drawing.Point(193, 81);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(61, 30);
            this.txtInch.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(129, 133);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Calculate";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rBtnImperial);
            this.grpUnit.Controls.Add(this.rBtnMetric);
            this.grpUnit.Location = new System.Drawing.Point(310, 34);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(263, 92);
            this.grpUnit.TabIndex = 12;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rBtnMetric
            // 
            this.rBtnMetric.AutoSize = true;
            this.rBtnMetric.Location = new System.Drawing.Point(7, 22);
            this.rBtnMetric.Name = "rBtnMetric";
            this.rBtnMetric.Size = new System.Drawing.Size(111, 20);
            this.rBtnMetric.TabIndex = 0;
            this.rBtnMetric.TabStop = true;
            this.rBtnMetric.Text = "Metric(kg, cm)";
            this.rBtnMetric.UseVisualStyleBackColor = true;
            // 
            // rBtnImperial
            // 
            this.rBtnImperial.AutoSize = true;
            this.rBtnImperial.Location = new System.Drawing.Point(7, 56);
            this.rBtnImperial.Name = "rBtnImperial";
            this.rBtnImperial.Size = new System.Drawing.Size(114, 20);
            this.rBtnImperial.TabIndex = 1;
            this.rBtnImperial.TabStop = true;
            this.rBtnImperial.Text = "Imperial(ft, lbs)";
            this.rBtnImperial.UseVisualStyleBackColor = true;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.label3);
            this.grpResults.Controls.Add(this.lblWeightCat);
            this.grpResults.Controls.Add(this.label4);
            this.grpResults.Controls.Add(this.lblBMI);
            this.grpResults.Controls.Add(this.label2);
            this.grpResults.Location = new System.Drawing.Point(35, 214);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(584, 100);
            this.grpResults.TabIndex = 13;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "   Results for";
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNormalBMI.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalBMI.ForeColor = System.Drawing.Color.Green;
            this.lblNormalBMI.Location = new System.Drawing.Point(35, 392);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(219, 23);
            this.lblNormalBMI.TabIndex = 10;
            this.lblNormalBMI.Text = "label3";
            this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Your BMI";
            // 
            // lblWeightCat
            // 
            this.lblWeightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCat.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightCat.Location = new System.Drawing.Point(262, 63);
            this.lblWeightCat.Name = "lblWeightCat";
            this.lblWeightCat.Size = new System.Drawing.Size(219, 23);
            this.lblWeightCat.TabIndex = 15;
            this.lblWeightCat.Text = "label5";
            this.lblWeightCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Weight Category";
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(262, 15);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(219, 23);
            this.lblBMI.TabIndex = 13;
            this.lblBMI.Text = "label3";
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your BMI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 638);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.lblNormalBMI);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInch);
            this.Controls.Add(this.txtCmFt);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "BMICalculator";
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtCmFt;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rBtnImperial;
        private System.Windows.Forms.RadioButton rBtnMetric;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeightCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNormalBMI;
    }
}

