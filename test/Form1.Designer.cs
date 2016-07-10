namespace test
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nbPiles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbFaces = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nb piles";
            // 
            // nbPiles
            // 
            this.nbPiles.AutoSize = true;
            this.nbPiles.Location = new System.Drawing.Point(128, 9);
            this.nbPiles.Name = "nbPiles";
            this.nbPiles.Size = new System.Drawing.Size(13, 13);
            this.nbPiles.TabIndex = 1;
            this.nbPiles.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nb faces";
            // 
            // nbFaces
            // 
            this.nbFaces.AccessibleName = "";
            this.nbFaces.AutoSize = true;
            this.nbFaces.Location = new System.Drawing.Point(128, 30);
            this.nbFaces.Name = "nbFaces";
            this.nbFaces.Size = new System.Drawing.Size(13, 13);
            this.nbFaces.TabIndex = 3;
            this.nbFaces.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Drop it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 112);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nbFaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nbPiles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nbPiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nbFaces;
        private System.Windows.Forms.Button button1;
    }
}

