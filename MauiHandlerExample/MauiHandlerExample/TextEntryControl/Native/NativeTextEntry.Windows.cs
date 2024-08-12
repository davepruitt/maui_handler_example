using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Win2D;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSize = Windows.Foundation.Size;

namespace MauiHandlerExample.TextEntryControl.Native
{
    public partial class NativeTextEntry : Microsoft.UI.Xaml.Controls.Grid, IDisposable
    {
        #region Private data members

        private TextBox _windows_text_box;

        #endregion

        #region Constructor

        public NativeTextEntry(TextEntry text_entry)
        {
            Setup(text_entry);

            _windows_text_box = new TextBox();

            this.Children.Add(_windows_text_box);
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
