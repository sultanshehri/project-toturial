namespace project_toturial
{
    partial class frmpic01
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
            this.btnImageFile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.btnImageResource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImageFile
            // 
            this.btnImageFile.Location = new System.Drawing.Point(181, 12);
            this.btnImageFile.Name = "btnImageFile";
            this.btnImageFile.Size = new System.Drawing.Size(171, 50);
            this.btnImageFile.TabIndex = 0;
            this.btnImageFile.Text = "Load Image from File";
            this.btnImageFile.UseVisualStyleBackColor = true;
            this.btnImageFile.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(664, 388);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(6, 23);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(284, 297);
            this.picTry.TabIndex = 2;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.picTry_Click);
            // 
            // btnImageResource
            // 
            this.btnImageResource.Location = new System.Drawing.Point(381, 12);
            this.btnImageResource.Name = "btnImageResource";
            this.btnImageResource.Size = new System.Drawing.Size(171, 50);
            this.btnImageResource.TabIndex = 4;
            this.btnImageResource.Text = "Load Image from Resource";
            this.btnImageResource.UseVisualStyleBackColor = true;
            this.btnImageResource.Click += new System.EventHandler(this.btnImageResource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Location = new System.Drawing.Point(62, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 327);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(319, 23);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(268, 297);
            this.picTry2.TabIndex = 3;
            this.picTry2.TabStop = false;
            this.picTry2.Click += new System.EventHandler(this.picTry2_Click);
            // 
            // frmpic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImageResource);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnImageFile);
            this.Name = "frmpic01";
            this.Text = "Picture Form 1";
            this.Load += new System.EventHandler(this.frmpic01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImageFile;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.Button btnImageResource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picTry2;
    }
}