using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsFactory_MSS_BarbuCristianAndrei.notificationsFactory
{
    internal class SMSNotifier : Notifier
    {
        public override INotifiable createNotification()
        {
            return new SMSNotification();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
