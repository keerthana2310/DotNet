using Mail_practice;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_practice
{
    internal class Mail
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set
            {
                _to = value;
            }
        }
        private string _from;
        public string From
        {
            get { return _from; }
            set
            {
                _from = value;
            }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
            }
        }
        private string _content;
        public string Content
        { get 
            { 
                return _content; 
            }
        set {
                _content = value;
            }
        }

        private DateTime _receivedDate;
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }


            set
            {
                _receivedDate = value;
            }
        }

        private double _size;
        public double Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }
        public Mail()
        {

        }
        public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            _id = id;
            _to = to;
            _from = from;
            _subject = subject;
            _content = content;
            _receivedDate = receivedDate;
            _size = size;
        }
        //public override string ToString()
        //{
        //    return string.Format ("\nId:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:{4}\nReceivedDate:{5}\nSize:{6}\n",Id,To,From, Subject, Content, ReceivedDate, Size);
        //}
        public override bool Equals(object obj)
        {
            Mail m = obj as Mail;
            if (m.To == To && m.From == From && m.Subject == Subject)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
           
        }
        public static Mail CreateMail(string detail)
        {
            string[] r=detail.Split(',');
            Mail m2=new Mail(long.Parse(r[0]),r[1],r[2],r[3],r[4],DateTime.ParseExact(r[5] ,"dd-mm-yyy",null),double.Parse(r[6]));
            return m2;
        }
        public override string ToString()
        {
            return String.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15:dd-mm-yyy}{6,15:0.0}", Id, From, To, Subject, Content, ReceivedDate, Size);
        }



    }
}
