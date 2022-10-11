
namespace noppaheitto_WLaitinen
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
            this.btn1Heitto = new System.Windows.Forms.Button();
            this.btn2Heitto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPelaaja1 = new System.Windows.Forms.Label();
            this.lblPelaaja2 = new System.Windows.Forms.Label();
            this.lblVoittaja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1Heitto
            // 
            this.btn1Heitto.Location = new System.Drawing.Point(66, 243);
            this.btn1Heitto.Name = "btn1Heitto";
            this.btn1Heitto.Size = new System.Drawing.Size(75, 45);
            this.btn1Heitto.TabIndex = 2;
            this.btn1Heitto.Text = "Pelaajan 1 heitto";
            this.btn1Heitto.UseVisualStyleBackColor = true;
            this.btn1Heitto.Click += new System.EventHandler(this.btn1Heitto_Click);
            // 
            // btn2Heitto
            // 
            this.btn2Heitto.Location = new System.Drawing.Point(249, 243);
            this.btn2Heitto.Name = "btn2Heitto";
            this.btn2Heitto.Size = new System.Drawing.Size(76, 45);
            this.btn2Heitto.TabIndex = 4;
            this.btn2Heitto.Text = "Pelaajan 2 heitto";
            this.btn2Heitto.UseVisualStyleBackColor = true;
            this.btn2Heitto.Click += new System.EventHandler(this.btn2Heitto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pelaajan 1 nopan arvo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pelaajan 2 nopan arvo:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(157, 328);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPelaaja1
            // 
            this.lblPelaaja1.AutoSize = true;
            this.lblPelaaja1.Location = new System.Drawing.Point(95, 150);
            this.lblPelaaja1.Name = "lblPelaaja1";
            this.lblPelaaja1.Size = new System.Drawing.Size(0, 15);
            this.lblPelaaja1.TabIndex = 8;
            // 
            // lblPelaaja2
            // 
            this.lblPelaaja2.AutoSize = true;
            this.lblPelaaja2.Location = new System.Drawing.Point(283, 150);
            this.lblPelaaja2.Name = "lblPelaaja2";
            this.lblPelaaja2.Size = new System.Drawing.Size(0, 15);
            this.lblPelaaja2.TabIndex = 9;
            // 
            // lblVoittaja
            // 
            this.lblVoittaja.AutoSize = true;
            this.lblVoittaja.Location = new System.Drawing.Point(140, 215);
            this.lblVoittaja.Name = "lblVoittaja";
            this.lblVoittaja.Size = new System.Drawing.Size(0, 15);
            this.lblVoittaja.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.lblVoittaja);
            this.Controls.Add(this.lblPelaaja2);
            this.Controls.Add(this.lblPelaaja1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2Heitto);
            this.Controls.Add(this.btn1Heitto);
            this.Name = "Form1";
            this.Text = "Nopanheitto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1Heitto;
        private System.Windows.Forms.Button btn2Heitto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPelaaja1;
        private System.Windows.Forms.Label lblPelaaja2;
        private System.Windows.Forms.Label lblVoittaja;
    }
}

