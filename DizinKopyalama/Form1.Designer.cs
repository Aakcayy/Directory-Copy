namespace DizinKopyalama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.klasorsecbtn = new System.Windows.Forms.Button();
            this.klasorkopyalabtn = new System.Windows.Forms.Button();
            this.txtHedefKlasor = new System.Windows.Forms.TextBox();
            this.txtKaynakKlasor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // klasorsecbtn
            // 
            this.klasorsecbtn.BackColor = System.Drawing.Color.MediumBlue;
            this.klasorsecbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.klasorsecbtn.Location = new System.Drawing.Point(330, 90);
            this.klasorsecbtn.Name = "klasorsecbtn";
            this.klasorsecbtn.Size = new System.Drawing.Size(190, 32);
            this.klasorsecbtn.TabIndex = 0;
            this.klasorsecbtn.Text = " Klasör Seç";
            this.klasorsecbtn.UseVisualStyleBackColor = false;
            this.klasorsecbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // klasorkopyalabtn
            // 
            this.klasorkopyalabtn.BackColor = System.Drawing.Color.MediumBlue;
            this.klasorkopyalabtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.klasorkopyalabtn.Location = new System.Drawing.Point(341, 261);
            this.klasorkopyalabtn.Name = "klasorkopyalabtn";
            this.klasorkopyalabtn.Size = new System.Drawing.Size(190, 34);
            this.klasorkopyalabtn.TabIndex = 1;
            this.klasorkopyalabtn.Text = "Klasörü Kopyala";
            this.klasorkopyalabtn.UseVisualStyleBackColor = false;
            this.klasorkopyalabtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtHedefKlasor
            // 
            this.txtHedefKlasor.BackColor = System.Drawing.Color.White;
            this.txtHedefKlasor.Location = new System.Drawing.Point(268, 202);
            this.txtHedefKlasor.Multiline = true;
            this.txtHedefKlasor.Name = "txtHedefKlasor";
            this.txtHedefKlasor.Size = new System.Drawing.Size(311, 40);
            this.txtHedefKlasor.TabIndex = 2;
            // 
            // txtKaynakKlasor
            // 
            this.txtKaynakKlasor.BackColor = System.Drawing.Color.White;
            this.txtKaynakKlasor.Location = new System.Drawing.Point(268, 34);
            this.txtKaynakKlasor.Multiline = true;
            this.txtKaynakKlasor.Name = "txtKaynakKlasor";
            this.txtKaynakKlasor.Size = new System.Drawing.Size(311, 40);
            this.txtKaynakKlasor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-1, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kopyalanacak Dizinin Konumu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = " Dizinin Kopyalandığı Konum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKaynakKlasor);
            this.Controls.Add(this.txtHedefKlasor);
            this.Controls.Add(this.klasorkopyalabtn);
            this.Controls.Add(this.klasorsecbtn);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dizin Kopyalama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button klasorsecbtn;
        private System.Windows.Forms.Button klasorkopyalabtn;
        private System.Windows.Forms.TextBox txtHedefKlasor;
        private System.Windows.Forms.TextBox txtKaynakKlasor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

