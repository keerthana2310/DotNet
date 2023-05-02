using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mail_practice
{
    internal class Mailfolder
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private List<Mail> _mailList = new List<Mail>();
        public List<Mail> MailList
        {
            get
            {
                return _mailList;
            }
            set
            {
                _mailList = value;
            }
        }
        public Mailfolder()
        { }
        public Mailfolder(string name, List<Mail> mailList)
        {

            _name = name;
            _mailList = mailList;
        }
        public void AddMailToFolder(Mail mail)
        {
            _mailList.Add(mail);
            Console.WriteLine("Mail successfully added");
        }
        public bool RemoveMailFromFolder(long id)
        {





            foreach (Mail mail in _mailList)
            {


                if (mail.Id== id)

                {
                    _mailList.Remove(mail);
                    Console.WriteLine("Mail successfully deleted ");


                    return true;
                }
            }
            
            Console.WriteLine("Mail not found");
               return false;

            
        }
        public void DisplayMails()
        {
            if (_mailList == null)
            {
                Console.WriteLine("no mails found");
            }
            else
            {
                Console.WriteLine("Mails in {0}", _mailList);
            }
                Console.WriteLine("Mails in {0}\n", _mailList);
            Console.WriteLine("{0}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}", "Id", "From", "To", "Subject", "Content", "ReceivedDate", "Size");
            foreach (Mail mail in _mailList)
                {
                    Console.WriteLine(mail);
                }
            
        }
    }
}













