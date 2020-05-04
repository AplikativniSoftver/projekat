namespace v1
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
            this.Velicina_stranica = new System.Windows.Forms.TextBox();
            this.Unos = new System.Windows.Forms.ListBox();
            this.Povrsina = new System.Windows.Forms.Label();
            this.Obim = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite stranicu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Velicina_stranica
            // 
            this.Velicina_stranica.Location = new System.Drawing.Point(96, 75);
            this.Velicina_stranica.Name = "Velicina_stranica";
            this.Velicina_stranica.Size = new System.Drawing.Size(100, 20);
            this.Velicina_stranica.TabIndex = 1;
            // 
            // Unos
            // 
            this.Unos.FormattingEnabled = true;
            this.Unos.Items.AddRange(new object[] {
            "Kvadrat",
            "JKSTrougao",
            "Krug"});
            this.Unos.Location = new System.Drawing.Point(96, 101);
            this.Unos.Name = "Unos";
            this.Unos.Size = new System.Drawing.Size(120, 43);
            this.Unos.TabIndex = 2;
            // 
            // Povrsina
            // 
            this.Povrsina.AutoSize = true;
            this.Povrsina.Location = new System.Drawing.Point(269, 101);
            this.Povrsina.Name = "Povrsina";
            this.Povrsina.Size = new System.Drawing.Size(0, 13);
            this.Povrsina.TabIndex = 3;
            // 
            // Obim
            // 
            this.Obim.AutoSize = true;
            this.Obim.Location = new System.Drawing.Point(269, 142);
            this.Obim.Name = "Obim";
            this.Obim.Size = new System.Drawing.Size(0, 13);
            this.Obim.TabIndex = 4;
            this.Obim.Click += new System.EventHandler(this.Obim_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Klik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Obim);
            this.Controls.Add(this.Povrsina);
            this.Controls.Add(this.Unos);
            this.Controls.Add(this.Velicina_stranica);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Velicina_stranica;
        private System.Windows.Forms.ListBox Unos;
        private System.Windows.Forms.Label Povrsina;
        private System.Windows.Forms.Label Obim;
        private System.Windows.Forms.Button button1;
    }
}

