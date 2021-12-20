using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsFactory_MSS_BarbuCristianAndrei.notificationsFactory
{
    public class MailNotification : INotifiable
    {
        public void notify()
        {
            Console.WriteLine("This is a MAIL notification");
        }
    }
}
