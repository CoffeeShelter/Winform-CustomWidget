using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloWidget.Event
{
    public class ModeChangedEventArgs : EventArgs
    {
        public string Mode { get; set; }
    }
}
