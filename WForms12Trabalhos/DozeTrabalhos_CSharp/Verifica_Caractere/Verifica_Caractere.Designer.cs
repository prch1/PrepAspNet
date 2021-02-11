
namespace Verifica_Caractere
{
    partial class Verifica_Caractere
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtCaractere = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(37, 20);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Informe o Caractere";
            // 
            // txtCaractere
            // 
            this.txtCaractere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaractere.Location = new System.Drawing.Point(75, 64);
            this.txtCaractere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCaractere.Name = "txtCaractere";
            this.txtCaractere.Size = new System.Drawing.Size(88, 26);
            this.txtCaractere.TabIndex = 1;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(75, 107);
            this.btnVerifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(88, 33);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(70, 157);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 30);
            this.lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 7F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 242);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtCaractere);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifica Caractere";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtCaractere;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblResultado;
    }
}

