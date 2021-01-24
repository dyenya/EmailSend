using System;
using System.Collections.Generic;
using AppKit;
using Foundation;
using System.Net.Mail;

namespace MailingSolution
{
    public partial class ViewController : NSViewController
    {
        //This is booloean variable to detect the sending
        private bool MessageSent = true;
        
        
        
        public ViewController(IntPtr handle) : base(handle)
        {
            
        }
        
        //This method called on start
        public override void ViewDidLoad()
        {
            //Load strings of Templates and inserts it combo box cells
            base.ViewDidLoad();
            SetLoaded(Database.LoadData());
        }


        
        partial void btnSend(NSButtonCell sender)
        {
            try
            {
                //using special library function collects data from text fields
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(fldFrom.StringValue);
                    mail.To.Add(fldTo.StringValue);
                    mail.Subject = fldSubject.StringValue;
                    mail.Body = fldBody.StringValue;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(fldFrom.StringValue, fldPassword.StringValue);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);


                    }
                }
            }
            catch (Exception ex)
            {
                //If mail, password are incorrect or text fields To and body of mail is empty - message won't be sent 
                MessageSent = false;
            }
            finally
            {
                if (MessageSent)
                {
                    fldStatus.StringValue = "Message sent";
                    
                    fldBody.StringValue = "";
                    fldTo.StringValue = "";
                    fldSubject.StringValue = "";
                    
                }
                else
                {
                    fldStatus.StringValue = "Invalid data";
                    MessageSent = true;
                }
            }
        }

        // adds to body any template from list
        partial void btnIncrement(NSButtonCell sender)
        {
            fldBody.StringValue += TemplateValue.StringValue;
            
        }

        //adds to list of combobox cells, created template in body field and save it
        partial void btnAdd(NSObject sender)
        {
            TemplateValue.Insert(new NSComboBoxCell(fldBody.StringValue), 0);
            Database.Templates.Add(fldBody.StringValue);
            Database.SaveData();
        }

        //deletes selected template
        partial void btnDelete(NSButtonCell sender)
        {
            Database.Templates.Remove(TemplateValue.StringValue);
            TemplateValue.Remove(TemplateValue.SelectedValue);
            TemplateValue.StringValue = "";
            Database.SaveData();
        }

        

        //Insert strings from list to combo box cells
        public void SetLoaded(List<string> templ)
        {
            foreach (string s in templ)
            {
                TemplateValue.Insert(new NSComboBoxCell(s), 0);
                
            }
            
        }
        
        
    }
}