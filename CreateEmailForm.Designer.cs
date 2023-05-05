
namespace SendEmail_01
{
    partial class CreateEmailForm
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
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxbMensaje = new System.Windows.Forms.TextBox();
            this.TxbAsunto = new System.Windows.Forms.TextBox();
            this.TxbPara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbDe = new System.Windows.Forms.TextBox();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(660, 300);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 35);
            this.BtnEnviar.TabIndex = 19;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(47, 305);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 35);
            this.BtnLimpiar.TabIndex = 18;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxbMensaje
            // 
            this.TxbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbMensaje.Location = new System.Drawing.Point(414, 76);
            this.TxbMensaje.Multiline = true;
            this.TxbMensaje.Name = "TxbMensaje";
            this.TxbMensaje.Size = new System.Drawing.Size(321, 207);
            this.TxbMensaje.TabIndex = 17;
            // 
            // TxbAsunto
            // 
            this.TxbAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbAsunto.Location = new System.Drawing.Point(46, 256);
            this.TxbAsunto.Name = "TxbAsunto";
            this.TxbAsunto.Size = new System.Drawing.Size(321, 26);
            this.TxbAsunto.TabIndex = 16;
            // 
            // TxbPara
            // 
            this.TxbPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbPara.Location = new System.Drawing.Point(39, 175);
            this.TxbPara.Name = "TxbPara";
            this.TxbPara.Size = new System.Drawing.Size(321, 26);
            this.TxbPara.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(411, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mensaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(40, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(37, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(37, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email Origen";
            // 
            // TxbDe
            // 
            this.TxbDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbDe.Location = new System.Drawing.Point(38, 53);
            this.TxbDe.Name = "TxbDe";
            this.TxbDe.Size = new System.Drawing.Size(321, 26);
            this.TxbDe.TabIndex = 21;
            // 
            // TxbPassword
            // 
            this.TxbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbPassword.Location = new System.Drawing.Point(39, 109);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(321, 26);
            this.TxbPassword.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(39, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password";
            // 
            // CreateEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 362);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.TxbDe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxbMensaje);
            this.Controls.Add(this.TxbAsunto);
            this.Controls.Add(this.TxbPara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CreateEmailForm";
            this.Text = "CreateEmailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxbMensaje;
        private System.Windows.Forms.TextBox TxbAsunto;
        private System.Windows.Forms.TextBox TxbPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbDe;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label label6;
    }
}