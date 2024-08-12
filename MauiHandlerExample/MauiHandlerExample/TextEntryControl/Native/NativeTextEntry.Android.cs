using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlerExample.TextEntryControl.Native
{
    public partial class NativeTextEntry : Android.Views.View
    {
        #region Private data members

        private Context _context;

        #endregion

        #region Constructor

        public NativeTextEntry(Context context, TextEntry text_entry)
            : base(context)
        {
            _context = context;
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
