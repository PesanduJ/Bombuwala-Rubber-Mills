using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace BombuwalaRubberMills
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void cb_Active_Click(object sender, EventArgs e)
        {
            if (cb_Active.Checked)
            {
                txt_from.Enabled = true;
                txt_password.Enabled = true;

            } 

            else
            {
                txt_from.Enabled = false;
                txt_password.Enabled = false;
            }   
        }

        private void llbl_attachfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.ShowDialog();
            lbl_location.Text = openFileDialog.FileName;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //email - bombuwalarubberm@gmail.com    
            //pw - rubbermills1!

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(txt_from.Text);
                mail.To.Add(txt_to.Text);
                mail.Subject = txt_tittle.Text;
                mail.Body = txt_body.Text;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(lbl_location.Text);
                mail.Attachments.Add(attachment);

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(txt_from.Text, txt_password.Text);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

                MetroFramework.MetroMessageBox.Show(this, "Mail has been successfully sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {
            lbl_location.Text = "";
        }
    }
}
