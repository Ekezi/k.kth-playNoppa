namespace kth_playNoppa
{
    partial class Form1
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
            this.btnP1 = new System.Windows.Forms.Button();
            this.btnP2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.picBoxWinner = new System.Windows.Forms.PictureBox();
            this.picBoxP1 = new System.Windows.Forms.PictureBox();
            this.picBoxP2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxP2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnP1
            // 
            this.btnP1.Location = new System.Drawing.Point(12, 12);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(75, 23);
            this.btnP1.TabIndex = 3;
            this.btnP1.Text = "P1";
            this.btnP1.UseVisualStyleBackColor = true;
            this.btnP1.Click += new System.EventHandler(this.btnP1_Click);
            // 
            // btnP2
            // 
            this.btnP2.Location = new System.Drawing.Point(349, 12);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(75, 23);
            this.btnP2.TabIndex = 4;
            this.btnP2.Text = "P2";
            this.btnP2.UseVisualStyleBackColor = true;
            this.btnP2.Click += new System.EventHandler(this.btnP2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picBoxWinner
            // 
            this.picBoxWinner.Location = new System.Drawing.Point(118, 41);
            this.picBoxWinner.Name = "picBoxWinner";
            this.picBoxWinner.Size = new System.Drawing.Size(200, 200);
            this.picBoxWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxWinner.TabIndex = 6;
            this.picBoxWinner.TabStop = false;
            // 
            // picBoxP1
            // 
            this.picBoxP1.Location = new System.Drawing.Point(12, 41);
            this.picBoxP1.Name = "picBoxP1";
            this.picBoxP1.Size = new System.Drawing.Size(100, 100);
            this.picBoxP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxP1.TabIndex = 7;
            this.picBoxP1.TabStop = false;
            // 
            // picBoxP2
            // 
            this.picBoxP2.Location = new System.Drawing.Point(324, 41);
            this.picBoxP2.Name = "picBoxP2";
            this.picBoxP2.Size = new System.Drawing.Size(100, 100);
            this.picBoxP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxP2.TabIndex = 8;
            this.picBoxP2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 251);
            this.Controls.Add(this.picBoxP2);
            this.Controls.Add(this.picBoxP1);
            this.Controls.Add(this.picBoxWinner);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnP2);
            this.Controls.Add(this.btnP1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxP2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnP1;
        private Button btnP2;
        private Button btnReset;
        private PictureBox picBoxWinner;
        private PictureBox picBoxP1;
        private PictureBox picBoxP2;
    }
}