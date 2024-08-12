using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlerExample.TextEntryControl.Native
{
    public partial class NativeTextEntry : IDisposable
    {
        #region Private data members

        private TextEntry _text_entry;

        #endregion

        #region Setup function

        private void Setup (TextEntry text_entry)
        {
            _text_entry = text_entry;
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            //empty
        }

        #endregion

        #region Update methods

        public void UpdateBackground ()
        {
            Platform_UpdateBackground();
        }

        public void UpdateStroke ()
        {
            Platform_UpdateStroke();
        }

        public void UpdateTextColor ()
        {
            Platform_UpdateTextColor();
        }

        public void UpdateText ()
        {
            Platform_UpdateText();
        }

        public void UpdateFontSize ()
        {
            Platform_UpdateFontSize();
        }

        public void UpdateIsPassword ()
        {
            Platform_UpdateIsPassword();
        }

        #endregion

        #region Partial methods that must be implemented by each platform

        partial void Platform_UpdateBackground();
        partial void Platform_UpdateStroke();
        partial void Platform_UpdateTextColor();
        partial void Platform_UpdateText();
        partial void Platform_UpdateFontSize();
        partial void Platform_UpdateIsPassword();

        #endregion
    }
}
