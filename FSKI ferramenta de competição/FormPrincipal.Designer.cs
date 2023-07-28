namespace FSKI_ferramenta_de_competição
{
    partial class FSK_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSK_Principal));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonKumite = new System.Windows.Forms.Button();
            this.buttonKata = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 293);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(280, 32);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonKumite
            // 
            this.buttonKumite.Location = new System.Drawing.Point(12, 255);
            this.buttonKumite.Name = "buttonKumite";
            this.buttonKumite.Size = new System.Drawing.Size(280, 32);
            this.buttonKumite.TabIndex = 1;
            this.buttonKumite.Text = "Kumite";
            this.buttonKumite.UseVisualStyleBackColor = true;
            this.buttonKumite.Click += new System.EventHandler(this.buttonKumite_Click);
            // 
            // buttonKata
            // 
            this.buttonKata.Location = new System.Drawing.Point(12, 217);
            this.buttonKata.Name = "buttonKata";
            this.buttonKata.Size = new System.Drawing.Size(280, 32);
            this.buttonKata.TabIndex = 2;
            this.buttonKata.Text = "Kata";
            this.buttonKata.UseVisualStyleBackColor = true;
            this.buttonKata.Click += new System.EventHandler(this.buttonKata_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FSKI_ferramenta_de_competição.Properties.Resources.FSK;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FSK_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonKata);
            this.Controls.Add(this.buttonKumite);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSK_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSK - Placar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonKumite;
        private System.Windows.Forms.Button buttonKata;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

