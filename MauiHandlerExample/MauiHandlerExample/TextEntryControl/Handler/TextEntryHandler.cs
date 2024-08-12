using MauiHandlerExample.TextEntryControl.Native;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlerExample.TextEntryControl.Handler
{
    public partial class TextEntryHandler : ViewHandler<TextEntry, NativeTextEntry>
    {
        #region Property mapper

        public static IPropertyMapper<TextEntry, TextEntryHandler> PropertyMapper = new PropertyMapper<TextEntry, TextEntryHandler>(ViewHandler.ViewMapper)
        {
            [nameof(TextEntry.Background)] = MapUpdateBackground,
            [nameof(TextEntry.Stroke)] = MapUpdateStroke,
            [nameof(TextEntry.TextColor)] = MapUpdateTextColor,
            [nameof(TextEntry.Text)] = MapUpdateText,
            [nameof(TextEntry.FontSize)] = MapUpdateFontSize,
            [nameof(TextEntry.IsPassword)] = MapUpdateIsPassword
        };

        #endregion

        #region Constructor

        public TextEntryHandler()
            : base(PropertyMapper)
        {
            //empty
        }

        #endregion

        #region Overrides

        protected override void ConnectHandler(NativeTextEntry platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(NativeTextEntry platformView)
        {
            base.DisconnectHandler(platformView);
        }

        #endregion

        #region Mapping methods

        public static void MapUpdateBackground(TextEntryHandler handler, TextEntry text_entry)
        {
            handler.PlatformView?.UpdateBackground();
        }

        public static void MapUpdateStroke(TextEntryHandler handler, TextEntry text_entry)
        {
            handler.PlatformView?.UpdateStroke();
        }

        public static void MapUpdateTextColor(TextEntryHandler handler, TextEntry text_entry)
        {
            handler.PlatformView?.UpdateTextColor();
        }

        public static void MapUpdateText(TextEntryHandler handler, TextEntry text_entry)
        {
            handler.PlatformView?.UpdateText();
        }

        public static void MapUpdateFontSize(TextEntryHandler handler, TextEntry text_entry)
        {
            handler.PlatformView?.UpdateFontSize();
        }

        public static void MapUpdateIsPassword(TextEntryHandler handler, TextEntry text_entry)
        {
            handler.PlatformView?.UpdateIsPassword();
        }

        #endregion
    }
}
