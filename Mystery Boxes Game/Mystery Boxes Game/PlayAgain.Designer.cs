
namespace Mystery_Boxes_Game
{
    partial class PlayAgain
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnLow = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(34, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(179, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Play Again";
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLow.Location = new System.Drawing.Point(34, 132);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(115, 40);
            this.btnLow.TabIndex = 3;
            this.btnLow.Text = "Low ($5)";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(45, 70);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(388, 42);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "...";
            // 
            // btnMed
            // 
            this.btnMed.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMed.Location = new System.Drawing.Point(166, 132);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(135, 40);
            this.btnMed.TabIndex = 8;
            this.btnMed.Text = "Medium ($10)";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnHigh
            // 
            this.btnHigh.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHigh.Location = new System.Drawing.Point(318, 132);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(115, 40);
            this.btnHigh.TabIndex = 9;
            this.btnHigh.Text = "High ($15)";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // PlayAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 241);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.lblHeading);
            this.Name = "PlayAgain";
            this.Text = "PlayAgain";
            this.Load += new System.EventHandler(this.PlayAgain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnHigh;
    }
}