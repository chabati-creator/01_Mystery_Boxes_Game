
namespace Mystery_Boxes_Game
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lbIHelp = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIHelp
            // 
            this.lbIHelp.Location = new System.Drawing.Point(25, 82);
            this.lbIHelp.Name = "lbIHelp";
            this.lbIHelp.Size = new System.Drawing.Size(442, 376);
            this.lbIHelp.TabIndex = 7;
            this.lbIHelp.Text = resources.GetString("lbIHelp.Text");
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(25, 28);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(368, 37);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Help / Payout Schedule";
            // 
            // btnDismiss
            // 
            this.btnDismiss.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDismiss.Location = new System.Drawing.Point(180, 451);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(115, 40);
            this.btnDismiss.TabIndex = 9;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 530);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lbIHelp);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIHelp;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnDismiss;
    }
}