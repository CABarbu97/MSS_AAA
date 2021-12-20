using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsFactory_MSS_BarbuCristianAndrei.notificationsFactory
{
    internal class PushNotification : INotifiable
    {
        public void notify()
        {
            Console.WriteLine("This is a PUSH Notification");
        }
    }
}
