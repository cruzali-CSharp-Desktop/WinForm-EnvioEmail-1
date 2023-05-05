using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmail_01
{
    public partial class CreateEmailForm : Form
    {
        const string Usuario = "";
        const string Password = "";

        public CreateEmailForm()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string Msg = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            MensajeBuilder.Append(TxbMensaje.Text.Trim());

            EnviarEmail(MensajeBuilder, DateTime.Now, TxbDe.Text.Trim(), TxbPara.Text.Trim(), 
                TxbAsunto.Text.Trim(), TxbDe.Text.Trim(), TxbPassword.Text, out Msg);
        }

        private static void EnviarEmail(StringBuilder Mensaje, DateTime FechaEnvio, string De, 
                    string Para, string Asunto, string emailOrigen, string passwordEmailOrigen, out string Msg)
        {
            Msg = "";

            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Este email ha sido enviado el día {0:dd/MM/yyyy} a las {0:HH:mm:ss} Hrs\n\n,", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString();

                /* En este caso que se usa Google como servidor SMTP, se requiere una serie de adecuaciones
                 * desde la cuenta de google a usar. 
                 * Dentro de "Verificacion de 2 pasos" / "Contraseñas de aplicaciones" se debe de agregar una contraseña de tipo Correo y dispositivo OTRO.
                 * */

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(emailOrigen, passwordEmailOrigen);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Msg = "Exito";

                MessageBox.Show(Msg);

            } catch (Exception ex)
            {
                Msg = "Error: " + ex.Message;
                MessageBox.Show(Msg);
                return;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxbDe.Text = string.Empty;
            TxbPara.Text = string.Empty;
            TxbAsunto.Text = string.Empty;
            TxbMensaje.Text = string.Empty;
        }
    }
}
