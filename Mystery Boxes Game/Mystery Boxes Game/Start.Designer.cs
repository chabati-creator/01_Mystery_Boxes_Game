
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
            this.btnLow.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLow.Location = new System.Drawing.Point(188, 278);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(106, 40);
            this.btnLow.TabIndex = 1;
            this.btnLow.Text = "Low ($5)";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudAmount.Location = new System.Drawing.Point(144, 209);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(191, 34);
            this.nudAmount.TabIndex = 2;
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
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 364);
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
    }
}

