using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;
using TextChangedEventArgs = Microsoft.Maui.Controls.TextChangedEventArgs;

namespace MauiHandlerExample.TextEntryControl
{
    public class TextEntry : View
    {
        #region Constructor

        public TextEntry()
        {
            //empty
        }

        #endregion

        #region Dependency properties

        public static readonly new BindableProperty BackgroundProperty =
            BindableProperty.Create(nameof(Background), typeof(Brush), typeof(TextEntry), null);

        public static readonly BindableProperty StrokeProperty =
            BindableProperty.Create(nameof(Stroke), typeof(Brush), typeof(TextEntry), null);

        public static readonly BindableProperty TextColorProperty =
                   BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(TextEntry), null);

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(TextEntry), string.Empty);

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(float), typeof(TextEntry), 12.0f);

        public static readonly BindableProperty IsPasswordProperty =
           BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(TextEntry), false);

        #endregion

        #region Properties

        public new Brush Background
        {
            get => (Brush)GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }

        public Brush Stroke
        {
            get => (Brush)GetValue(StrokeProperty);
            set => SetValue(StrokeProperty, value);
        }

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public float FontSize
        {
            get => (float)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public bool IsPassword
        {
            get => (bool)GetValue(IsPasswordProperty);
            set => SetValue(IsPasswordProperty, value);
        }

        #endregion

        #region Events

        public event EventHandler<TextChangedEventArgs>? TextChanged;

        #endregion
    }
}
