
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStats));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblGameStats = new System.Windows.Forms.Label();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(32, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(261, 37);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Game Statistics";
            // 
            // lblGameStats
            // 
            this.lblGameStats.Location = new System.Drawing.Point(32, 65);
            this.lblGameStats.Name = "lblGameStats";
            this.lblGameStats.Size = new System.Drawing.Size(442, 247);
            this.lblGameStats.TabIndex = 8;
            this.lblGameStats.Text = resources.GetString("lblGameStats.Text");
            // 
            // btnDismiss
            // 
            this.btnDismiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDismiss.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDismiss.Location = new System.Drawing.Point(285, 315);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(115, 40);
            this.btnDismiss.TabIndex = 10;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = false;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightBlue;
            this.btnExport.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.Location = new System.Drawing.Point(128, 315);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 40);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // GameStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 376);
            this.Controls.Add(this.btnExport);
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
        private System.Windows.Forms.Button btnExport;
    }
}