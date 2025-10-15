using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.EmailProcess
{
    public interface IEmailManager
    {
        public bool Gmail_ileMailGonder(EmailMessageModel model);
        public bool Gmail_Gonder_AttachmentExcel(EmailMessageModel model, XLWorkbook workbook);
        public bool Outlook_ileMailGonder(EmailMessageModel model);

    }
}
