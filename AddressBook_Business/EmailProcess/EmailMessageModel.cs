using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.EmailProcess
{
    public class EmailMessageModel
    {
        public string SenderEmail { get; set; }
        public string SenderTitle { get; set; }
        public string[] ToEmail { get; set; }
        public string[]? CCEmails { get; set; }
        public string[]? BCCEmails { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
