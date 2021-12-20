using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsFactory_MSS_BarbuCristianAndrei.notificationsFactory
{
    public abstract class Notifier
    {
        public abstract INotifiable createNotification();

        public  void sendNotification()
        {
            INotifiable notification = createNotification();
            notification.notify();
        }
    }
}
