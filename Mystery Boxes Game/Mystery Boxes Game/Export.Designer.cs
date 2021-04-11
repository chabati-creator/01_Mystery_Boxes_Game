
namespace Mystery_Boxes_Game
{
    partial class Export
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
            this.lblExport = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.txbExport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(43, 29);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(118, 37);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Export";
            // 
            // lblExport
            // 
            this.lblExport.Location = new System.Drawing.Point(43, 80);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(372, 85);
            this.lblExport.TabIndex = 9;
            this.lblExport.Text = "Please enter the desired filename below. Your game statistics and round history w" +
    "ill be exported as a txt file and will appear in the same folder as this program" +
    ".";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightBlue;
            this.btnExport.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.Location = new System.Drawing.Point(87, 241);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 40);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Save";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDismiss.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDismiss.Location = new System.Drawing.Point(248, 241);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(115, 40);
            this.btnDismiss.TabIndex = 13;
            this.btnDismiss.Text = "Cancel";
            this.btnDismiss.UseVisualStyleBackColor = false;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // txbExport
            // 
            this.txbExport.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbExport.Location = new System.Drawing.Point(50, 158);
            this.txbExport.Multiline = true;
            this.txbExport.Name = "txbExport";
            this.txbExport.Size = new System.Drawing.Size(341, 56);
            this.txbExport.TabIndex = 14;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 312);
            this.Controls.Add(this.txbExport);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.lblHeading);
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.TextBox txbExport;
    }
}