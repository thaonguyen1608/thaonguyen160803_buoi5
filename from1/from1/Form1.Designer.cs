namespace from1
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
            this.components = new System.ComponentModel.Container();
            this.Show = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Yourname = new System.Windows.Forms.Label();
            this.Yearofbirth = new System.Windows.Forms.Label();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(18, 155);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 0;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(99, 155);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(185, 155);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Yourname
            // 
            this.Yourname.AutoSize = true;
            this.Yourname.Location = new System.Drawing.Point(30, 64);
            this.Yourname.Name = "Yourname";
            this.Yourname.Size = new System.Drawing.Size(63, 13);
            this.Yourname.TabIndex = 3;
            this.Yourname.Text = "Your Name ";
            this.Yourname.Click += new System.EventHandler(this.label1_Click);
            // 
            // Yearofbirth
            // 
            this.Yearofbirth.AutoSize = true;
            this.Yearofbirth.Location = new System.Drawing.Point(26, 108);
            this.Yearofbirth.Name = "Yearofbirth";
            this.Yearofbirth.Size = new System.Drawing.Size(67, 13);
            this.Yearofbirth.TabIndex = 4;
            this.Yearofbirth.Text = "Year of birth ";
            this.Yearofbirth.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(121, 61);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(139, 20);
            this.txtYourName.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(121, 105);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(139, 20);
            this.txtYear.TabIndex = 6;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.Yearofbirth);
            this.Controls.Add(this.Yourname);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Yourname;
        private System.Windows.Forms.Label Yearofbirth;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

