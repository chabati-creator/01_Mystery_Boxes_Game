
namespace Mystery_Boxes_Game
{
    partial class Start
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnLow = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(41, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(304, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Mystery Box Game";
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLow.Location = new System.Drawing.Point(41, 267);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(115, 40);
            this.btnLow.TabIndex = 1;
            this.btnLow.Text = "Low ($5)";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudAmount.Location = new System.Drawing.Point(144, 209);
            this.nudAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(191, 34);
            this.nudAmount.TabIndex = 2;
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbName.Location = new System.Drawing.Point(146, 159);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(189, 30);
            this.txbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(43, 163);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(43, 77);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(412, 66);
            this.lblInstruction.TabIndex = 5;
            this.lblInstruction.Text = "Please enter your name and a dollar amount (between $5 and $50) in the boxes belo" +
    "w. Then choose the stakes. The higher the stakes, the more you can win!";
            // 
            // btnMed
            // 
            this.btnMed.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMed.Location = new System.Drawing.Point(166, 267);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(140, 40);
            this.btnMed.TabIndex = 6;
            this.btnMed.Text = "Medium ($10)";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnHigh
            // 
            this.btnHigh.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHigh.Location = new System.Drawing.Point(314, 267);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(115, 40);
            this.btnHigh.TabIndex = 7;
            this.btnHigh.Text = "High ($15)";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(113, 323);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(115, 40);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help / Rules";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 396);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.lblHeading);
            this.Name = "Start";
            this.Text = "Mystery Box Game";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.Button btnHelp;
    }
}

