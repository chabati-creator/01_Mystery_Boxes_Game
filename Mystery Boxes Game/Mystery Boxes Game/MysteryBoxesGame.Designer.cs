
namespace Mystery_Boxes_Game
{
    partial class MysteryBoxesGame
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
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(67, 56);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(304, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Mystery Box Game";
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLow.Location = new System.Drawing.Point(163, 191);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(106, 40);
            this.btnLow.TabIndex = 1;
            this.btnLow.Text = "Low ($5)";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // numUpDown
            // 
            this.numUpDown.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDown.Location = new System.Drawing.Point(67, 124);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(304, 34);
            this.numUpDown.TabIndex = 2;
            // 
            // MysteryBoxesGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 386);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.lblHeading);
            this.Name = "MysteryBoxesGame";
            this.Text = "MysteryBoxesGame";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.NumericUpDown numUpDown;
    }
}

