using System.Windows.Forms;

namespace PLATZINIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCartaJugador = new System.Windows.Forms.Label();
            this.btnGredit = new System.Windows.Forms.Button();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelJugador = new System.Windows.Forms.Label();
            this.labelCasino = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCartaCasino = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxResult.Location = new System.Drawing.Point(71, 164);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(223, 59);
            this.textBoxResult.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.btnPlay.Location = new System.Drawing.Point(223, 113);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "JUGAR";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "P l a t s i n o";
            // 
            // labelCartaJugador
            // 
            this.labelCartaJugador.AutoSize = true;
            this.labelCartaJugador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCartaJugador.Location = new System.Drawing.Point(152, 103);
            this.labelCartaJugador.Name = "labelCartaJugador";
            this.labelCartaJugador.Size = new System.Drawing.Size(19, 21);
            this.labelCartaJugador.TabIndex = 3;
            this.labelCartaJugador.Text = "0";
            // 
            // btnGredit
            // 
            this.btnGredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.btnGredit.Location = new System.Drawing.Point(75, 71);
            this.btnGredit.Name = "btnGredit";
            this.btnGredit.Size = new System.Drawing.Size(75, 23);
            this.btnGredit.TabIndex = 5;
            this.btnGredit.Text = "CREDITS";
            this.btnGredit.UseVisualStyleBackColor = true;
            this.btnGredit.Click += new System.EventHandler(this.btnGredit_Click);
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.textBoxCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCredit.Location = new System.Drawing.Point(174, 71);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(30, 23);
            this.textBoxCredit.TabIndex = 6;
            this.textBoxCredit.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "TOTAL:";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCredit.Location = new System.Drawing.Point(271, 71);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(19, 21);
            this.labelCredit.TabIndex = 8;
            this.labelCredit.Text = "5";
            // 
            // labelJugador
            // 
            this.labelJugador.AutoSize = true;
            this.labelJugador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelJugador.Location = new System.Drawing.Point(113, 259);
            this.labelJugador.Name = "labelJugador";
            this.labelJugador.Size = new System.Drawing.Size(19, 21);
            this.labelJugador.TabIndex = 9;
            this.labelJugador.Text = "0";
            // 
            // labelCasino
            // 
            this.labelCasino.AutoSize = true;
            this.labelCasino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCasino.Location = new System.Drawing.Point(224, 259);
            this.labelCasino.Name = "labelCasino";
            this.labelCasino.Size = new System.Drawing.Size(19, 21);
            this.labelCasino.TabIndex = 10;
            this.labelCasino.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "JUGADOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "PLATSINO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.label8.Location = new System.Drawing.Point(35, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "JUGADOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "PLATSINO:";
            // 
            // lblCartaCasino
            // 
            this.lblCartaCasino.AutoSize = true;
            this.lblCartaCasino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartaCasino.Location = new System.Drawing.Point(152, 129);
            this.lblCartaCasino.Name = "lblCartaCasino";
            this.lblCartaCasino.Size = new System.Drawing.Size(19, 21);
            this.lblCartaCasino.TabIndex = 18;
            this.lblCartaCasino.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(406, 302);
            this.Controls.Add(this.lblCartaCasino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCasino);
            this.Controls.Add(this.labelJugador);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.btnGredit);
            this.Controls.Add(this.labelCartaJugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.textBoxResult);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxResult;
        private Button btnPlay;
        private Label label1;
        private Label labelCartaJugador;
        private Button btnGredit;
        private TextBox textBoxCredit;
        private Label label3;
        private Label labelCredit;
        private Label labelJugador;
        private Label labelCasino;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label2;
        private Label label4;
        private Label lblCartaCasino;
    }
}