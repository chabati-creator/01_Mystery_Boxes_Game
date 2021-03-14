
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnOpenBoxes = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(43, 28);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(107, 37);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Play...";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(43, 79);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(388, 42);
            this.lblInstruction.TabIndex = 6;
            this.lblInstruction.Text = "Click the \'Open Boxes\' button to reveal the contents of the boxes";
            // 
            // btnOpenBoxes
            // 
            this.btnOpenBoxes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenBoxes.Location = new System.Drawing.Point(150, 221);
            this.btnOpenBoxes.Name = "btnOpenBoxes";
            this.btnOpenBoxes.Size = new System.Drawing.Size(169, 36);
            this.btnOpenBoxes.TabIndex = 10;
            this.btnOpenBoxes.Text = "Open Boxes";
            this.btnOpenBoxes.UseVisualStyleBackColor = true;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(43, 124);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(119, 80);
            this.pb1.TabIndex = 11;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(171, 124);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(129, 80);
            this.pb2.TabIndex = 12;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(310, 124);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(121, 80);
            this.pb3.TabIndex = 13;
            this.pb3.TabStop = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 362);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnOpenBoxes);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblHeading);
            this.Name = "Play";
            this.Text = "Mystery Box Game";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnOpenBoxes;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
    }
}