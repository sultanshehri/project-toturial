namespace project_toturial
{
    partial class Form4
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
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnRemoveP = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(138, 173);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(155, 24);
            this.CmbDays.TabIndex = 0;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(69, 66);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(135, 50);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "Show Selected method1";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Selected method 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Selected method 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(399, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove 2nd last item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnRemoveP
            // 
            this.BtnRemoveP.Location = new System.Drawing.Point(69, 254);
            this.BtnRemoveP.Name = "BtnRemoveP";
            this.BtnRemoveP.Size = new System.Drawing.Size(135, 50);
            this.BtnRemoveP.TabIndex = 5;
            this.BtnRemoveP.Text = "Remove by Index";
            this.BtnRemoveP.UseVisualStyleBackColor = true;
            this.BtnRemoveP.Click += new System.EventHandler(this.BtnRemoveP_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(399, 159);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(135, 50);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Remove last Item";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "Remove by name";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnRemoveP);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CmbDays);
            this.Name = "Form4";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnRemoveP;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}