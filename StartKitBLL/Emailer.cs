using StarterKITDAL;
using System;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace StartKitBLL
{
    public interface IEmailer
    {
        string SendEmail(Contact email);
    }
    public class Emailer : IEmailer
    {
        public string SendEmail(Contact email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.ReplyToList.Add(new MailAddress(email.Email));
                mail.From = new MailAddress("dhakahandicraftsltdweb@gmail.com");
                mail.To.Add("website@dhakahandicrafts.com");
                mail.Subject = email.Subject;
                mail.Body = "My email address is: " + email.Email + " Message:" + email.Message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("dhakahandicraftsltdweb@gmail.com", "bzmenqugfbbluhbf");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("mail Send");
                return "true";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return ex.Message + "|" + ex.InnerException;
            }
            // Specify the file to be attached and sent.
            // This example assumes that a file named Data.xls exists in the
            // current working directory.
            // Create a message and set up the recipients.
            //MailMessage message = new MailMessage(
            //    "web@dhakahandicrafts.com",
            //   // "suahmed@dhakahandicrafts.com,website@dhakahandicrafts.com,sajid.ict@hotmail.com",
            //  // "website@dhakahandicrafts.com,sajid.ict@hotmail.com",
            //  "sajid.ict@gmail.com",
            //    email.Subject,
            //    "My email address is:"+  email.Email+" Message:" + email.Message);
            //message.ReplyToList.Add(new MailAddress(email.Email));
            // Create  the file attachment for this email message.
            //  Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
            // Add time stamp information for the file.
            //ContentDisposition disposition = data.ContentDisposition;
            //disposition.CreationDate = System.IO.File.GetCreationTime(file);
            //disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            //disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            // Add the file attachment to this email message.
            // message.Attachments.Add(data);

            //Send the message.
          //  //  SmtpClient client = new SmtpClient("mail.rexsystemsbd.com", 8889);
          //  SmtpClient client = new SmtpClient("mail.dhakahandicrafts.com", 26);
          //  client.UseDefaultCredentials = false;
          ////  NetworkCredential MyCredentials = new NetworkCredential("web@dhakahandicrafts.com", "Root@pass1");
          //  NetworkCredential MyCredentials = new NetworkCredential("web@dhakahandicrafts.com", "bzmenqugfbbluhbf");

          //  // NetworkCredential MyCredentials = new NetworkCredential("dhakahandicraftsltdweb@gmail.com", "dhakahandicraftsltdweb002");

          //  // Add credentials if the SMTP server requires them.
          //  client.Credentials = MyCredentials;
          //  try
          //  {
          //      client.Send(message);
          //      return "true";
          //  }
          //  catch (Exception ex)
          //  {
          //      return ex.Message + "|" + ex.InnerException;

          //  }
            // Display the values in the ContentDisposition for the attachment.
            //ContentDisposition cd = data.ContentDisposition;
            //Console.WriteLine("Content disposition");
            //Console.WriteLine(cd.ToString());
            //Console.WriteLine("File {0}", cd.FileName);
            //Console.WriteLine("Size {0}", cd.Size);
            //Console.WriteLine("Creation {0}", cd.CreationDate);
            //Console.WriteLine("Modification {0}", cd.ModificationDate);
            //Console.WriteLine("Read {0}", cd.ReadDate);
            //Console.WriteLine("Inline {0}", cd.Inline);
            //Console.WriteLine("Parameters: {0}", cd.Parameters.Count);
            //foreach (DictionaryEntry d in cd.Parameters)
            //{
            //    Console.WriteLine("{0} = {1}", d.Key, d.Value);
            //}
            //data.Dispose();
        }
    }
}
