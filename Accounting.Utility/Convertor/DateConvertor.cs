using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Convertor
{
    public static  class DateConvertor
    {

        public static string ToShamsi(this DateTime datetime)
        {
            PersianCalendar p = new PersianCalendar();
            return p.GetYear(datetime) +"/"+ p.GetMonth(datetime).ToString("00")+"/"+ p.GetDayOfMonth(datetime).ToString("00");
        }
    }
}
