using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class Account
    {
        public static ReportView ReportMain()
        {
            ReportView reportView = new ReportView();
            using (UnitofWorks db = new UnitofWorks())
            {
                DateTime StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 31).AddDays(1);

                var Receive = db.AccountingRepository.Get(a => a.TypeID == 1 && a.DateTime >= StartDate && a.DateTime <= EndDate).Select(a=> a.Amount).ToList();
                var Pay = db.AccountingRepository.Get(a => a.TypeID == 2 && a.DateTime >= StartDate && a.DateTime <= EndDate).Select(a => a.Amount).ToList();

                reportView.Receive = Receive.Sum();
                reportView.Pay = Pay.Sum();
                reportView.Balance = (Receive.Sum() - Pay.Sum());
            }

            return reportView;
        }
    }
}
