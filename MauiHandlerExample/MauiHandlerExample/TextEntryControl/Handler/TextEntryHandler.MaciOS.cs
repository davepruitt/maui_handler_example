using MauiHandlerExample.TextEntryControl.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlerExample.TextEntryControl.Handler
{
    public partial class TextEntryHandler
    {
        protected override NativeTextEntry CreatePlatformView()
        {
            return new NativeTextEntry(VirtualView);
        }
    }
}
