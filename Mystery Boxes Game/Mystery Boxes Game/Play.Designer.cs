
namespace Mystery_Boxes_Game
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnOpenBoxes = new System.Windows.Forms.Button();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnGameStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(50, 34);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(107, 37);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Play...";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(53, 76);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(388, 42);
            this.lblInstruction.TabIndex = 6;
            this.lblInstruction.Text = "Click the \'Open Boxes\' button to reveal the contents of the boxes";
            // 
            // btnOpenBoxes
            // 
            this.btnOpenBoxes.BackColor = System.Drawing.Color.Silver;
            this.btnOpenBoxes.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenBoxes.Location = new System.Drawing.Point(158, 246);
            this.btnOpenBoxes.Name = "btnOpenBoxes";
            this.btnOpenBoxes.Size = new System.Drawing.Size(169, 36);
            this.btnOpenBoxes.TabIndex = 10;
            this.btnOpenBoxes.Text = "Open Boxes";
            this.btnOpenBoxes.UseVisualStyleBackColor = false;
            this.btnOpenBoxes.Click += new System.EventHandler(this.btnOpenBoxes_Click);
            // 
            // pbx1
            // 
            this.pbx1.Image = ((System.Drawing.Image)(resources.GetObject("pbx1.Image")));
            this.pbx1.Location = new System.Drawing.Point(57, 129);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(107, 101);
            this.pbx1.TabIndex = 11;
            this.pbx1.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Image = ((System.Drawing.Image)(resources.GetObject("pbx2.Image")));
            this.pbx2.Location = new System.Drawing.Point(185, 129);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(107, 101);
            this.pbx2.TabIndex = 14;
            this.pbx2.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Image = ((System.Drawing.Image)(resources.GetObject("pbx3.Image")));
            this.pbx3.Location = new System.Drawing.Point(310, 129);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(107, 101);
            this.pbx3.TabIndex = 15;
            this.pbx3.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Silver;
            this.btnPlayAgain.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayAgain.Location = new System.Drawing.Point(248, 296);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(169, 40);
            this.btnPlayAgain.TabIndex = 16;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnGameStats
            // 
            this.btnGameStats.BackColor = System.Drawing.Color.LightBlue;
            this.btnGameStats.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGameStats.Location = new System.Drawing.Point(57, 298);
            this.btnGameStats.Name = "btnGameStats";
            this.btnGameStats.Size = new System.Drawing.Size(169, 36);
            this.btnGameStats.TabIndex = 19;
            this.btnGameStats.Text = "Game Statistics";
            this.btnGameStats.UseVisualStyleBackColor = false;
            this.btnGameStats.Click += new System.EventHandler(this.btnGameStats_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 352);
            this.Controls.Add(this.btnGameStats);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.btnOpenBoxes);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblHeading);
            this.Name = "Play";
            this.Text = "Mystery Box Game";
            this.Load += new System.EventHandler(this.Play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnOpenBoxes;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnGameStats;
    }
}