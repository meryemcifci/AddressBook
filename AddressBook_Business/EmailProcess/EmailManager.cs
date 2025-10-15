using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.EmailProcess
{
    public class EmailManager:IEmailManager
    {
        public bool Gmail_Gonder_AttachmentExcel(EmailMessageModel model, XLWorkbook workbook)
        {
            try
            {
                //email göndersin
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("edu2025Sinif@gmail.com", model.SenderTitle);
                foreach (var item in model.ToEmail)
                {
                    mail.To.Add(item);
                }
                if (model.CCEmails != null)
                {
                    foreach (var item in model.CCEmails)
                    {
                        mail.CC.Add(item);
                    }
                }

                if (model.BCCEmails != null)
                {
                    foreach (var item in model.BCCEmails)
                    {
                        mail.Bcc.Add(item);
                    }
                }
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Subject = model.Subject;
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Body = model.Body;

                System.IO.MemoryStream theStream = new System.IO.MemoryStream();
                workbook.SaveAs(theStream);
                byte[] byteArr = theStream.ToArray();
                System.IO.MemoryStream stream1 = new System.IO.MemoryStream(byteArr, true);
                stream1.Write(byteArr, 0, byteArr.Length);
                stream1.Position = 0;
                mail.Attachments.Add(new Attachment(stream1, $"{workbook.Author}.xlsx"));


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                //SmtpClient client = new SmtpClient();
                //client.Host = outlookSenderHost;
                //client.Port = outlookSenderPort;

                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("edu2025Sinif@gmail.com", "msql evaq vask rqus");
                client.Send(mail);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Gmail_ileMailGonder(EmailMessageModel model)
        {
            try
            {
                //email göndersin
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("edu2025Sinif@gmail.com", model.SenderTitle);
                foreach (var item in model.ToEmail)
                {
                    mail.To.Add(item);
                }
                if (model.CCEmails != null)
                {
                    foreach (var item in model.CCEmails)
                    {
                        mail.CC.Add(item);
                    }
                }

                if (model.BCCEmails != null)
                {
                    foreach (var item in model.BCCEmails)
                    {
                        mail.Bcc.Add(item);
                    }
                }
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Subject = model.Subject;
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Body = model.Body;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                //SmtpClient client = new SmtpClient();
                //client.Host = outlookSenderHost;
                //client.Port = outlookSenderPort;

                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("edu2025Sinif@gmail.com", "msql evaq vask rqus");
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Outlook_ileMailGonder(EmailMessageModel model)
        {
            try
            {

                //email göndersin
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("edu2025Sinif@outlook.com", model.SenderTitle);
                foreach (var item in model.ToEmail)
                {
                    mail.To.Add(item);
                }
                if (model.CCEmails != null)
                {
                    foreach (var item in model.CCEmails)
                    {
                        mail.CC.Add(item);
                        mail.CC.Add("edu2025Sinif@gmail.com");
                    }
                }

                if (model.BCCEmails != null)
                {
                    foreach (var item in model.BCCEmails)
                    {
                        mail.Bcc.Add(item);
                    }
                }
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Subject = model.Subject;
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Body = model.Body;

                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                //SmtpClient client = new SmtpClient();
                //client.Host = outlookSenderHost;
                //client.Port = outlookSenderPort;

                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("edu2025Sinif@outlook.com", "tiwomnaesummtofw");
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
