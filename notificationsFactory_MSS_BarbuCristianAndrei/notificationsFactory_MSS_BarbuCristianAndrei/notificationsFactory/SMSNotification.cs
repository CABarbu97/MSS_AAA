using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsFactory_MSS_BarbuCristianAndrei.notificationsFactory
{
    internal class SMSNotification : INotifiable
    {
        public void notify()
        {
            Console.WriteLine("This is SMS Notification");
        }
    }
}
