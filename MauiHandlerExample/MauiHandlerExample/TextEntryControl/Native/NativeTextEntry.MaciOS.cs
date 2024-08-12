using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlerExample.TextEntryControl.Native
{
    public partial class NativeTextEntry : UIKit.UIView
    {
        #region Constructor

        public NativeTextEntry(TextEntry text_entry)
        {
            Setup(text_entry);
        }

        #endregion

        #region Implementation of partial methods on a per-platform basis

        partial void Platform_UpdateBackground()
        {

        }

        partial void Platform_UpdateStroke()
        {

        }

        partial void Platform_UpdateTextColor()
        {

        }

        partial void Platform_UpdateText()
        {

        }

        partial void Platform_UpdateFontSize()
        {

        }

        partial void Platform_UpdateIsPassword()
        {

        }

        #endregion
    }
}
