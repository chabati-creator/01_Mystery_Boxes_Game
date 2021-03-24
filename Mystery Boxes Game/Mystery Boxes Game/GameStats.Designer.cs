
namespace Mystery_Boxes_Game
{
    partial class GameStats
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
            this.lblGameStats = new System.Windows.Forms.Label();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(32, 26);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(261, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Game Statistics";
            // 
            // lblGameStats
            // 
            this.lblGameStats.Location = new System.Drawing.Point(32, 65);
            this.lblGameStats.Name = "lblGameStats";
            this.lblGameStats.Size = new System.Drawing.Size(442, 196);
            this.lblGameStats.TabIndex = 8;
            this.lblGameStats.Text = "Starting Balance: $ ##\r\n\r\nCurrent Balance: $ ##\r\n\r\nAmount Won / Lost: $ ## << Lab" +
    "el will change\r\nto \'Won / Lost\'>>\r\n\r\nRounds Played: #";
            // 
            // btnDismiss
            // 
            this.btnDismiss.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDismiss.Location = new System.Drawing.Point(202, 233);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(115, 40);
            this.btnDismiss.TabIndex = 10;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // GameStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 283);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.lblGameStats);
            this.Controls.Add(this.lblHeading);
            this.Name = "GameStats";
            this.Text = "OpenBox";
            this.Load += new System.EventHandler(this.GameStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblGameStats;
        private System.Windows.Forms.Button btnDismiss;
    }
}