using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SDRSharp.FrequencyNavigation
{
    public partial class FrequencyInputPad : Form
    {
        private bool _allowNegative;

        public FrequencyInputPad()
        {
            InitializeComponent();

            Value = 0;
            minusButton.Visible = _allowNegative;
            decimalSeparatorButton.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // In order to submit form on Enter key, we need to prevent buttons from hiding it.
            // Just in case someone opened this form to type in value by keyboard.
            foreach (var button in tableLayoutPanel1.Controls.OfType<Button>())
            {
                button.PreviewKeyDown += (sender, args) =>
                    {
                        if (args.KeyCode == Keys.Enter)
                        {
                            args.IsInputKey = true;
                        }
                    };
            }
        }


        public decimal Value { get; private set; }

        [Description("Allow input of negative frequencies.")]
        [DefaultValue(false)]
        public bool AllowNegative
        {
            get { return _allowNegative; }
            set
            {
                _allowNegative = value;
                minusButton.Visible = _allowNegative;
            }
        }


        public void RelativeAlign(Control control, ContentAlignment alignment, int distance)
        {
            var baseBounds = control.RectangleToScreen(control.DisplayRectangle);
            var screenBounds = SystemInformation.VirtualScreen;
            var thisBounds = DisplayRectangle;

            switch (alignment)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    Top = baseBounds.Top - distance - thisBounds.Height;
                    break;
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                    Top = baseBounds.Top + baseBounds.Height/2 - thisBounds.Height/2;
                    break;
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                    Top = baseBounds.Bottom + distance;
                    break;
            }
            switch (alignment)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    Left = baseBounds.Left - distance - thisBounds.Width;
                    break;
                case ContentAlignment.TopCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.BottomCenter:
                    Left = baseBounds.Left + baseBounds.Width / 2 - thisBounds.Width / 2;
                    break;
                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    Left = baseBounds.Right + distance;
                    break;
            }

            if (Left < 0) { Left = 0; }
            if (Right > screenBounds.Width) { Left = screenBounds.Width - Width; }
            if (Top < 0) { Top = 0; }
            if (Bottom > screenBounds.Height) { Top = screenBounds.Height - Height; }
        }


        private bool AddChar(char c)
        {
            var s = valueTextBox.Text;
            if (Char.IsDigit(c))
            {
                s += c;
            }
            if (c == '.' || c == ',')
            {
                var sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                if (!s.Contains(sep))
                {
                    s += sep;
                }
            }
            if (_allowNegative && c == '-')
            {
                if (s.Contains("-"))
                {
                    s = s.Replace("-", "");
                }
                else
                {
                    s = "-" + s;
                }
            }
            if (valueTextBox.Text != s)
            {
                valueTextBox.Text = s;
                return true;
            }
            return false;
        }

        private void RemoveChar()
        {
            var s = valueTextBox.Text;
            if (s == "") { return; }
            valueTextBox.Text = s.Substring(0, s.Length - 1);
        }

        private void AcceptInput(decimal multiplier)
        {
            decimal d;
            if (decimal.TryParse(valueTextBox.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out d) ||
                decimal.TryParse(valueTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out d))
            {
                Value = multiplier * d;
                DialogResult = DialogResult.OK;
            }
        }


        private void NumberButtonClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var tag = (string)btn.Tag;
            AddChar(Convert.ToChar(tag));
        }

        private void FrequencyInputPad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'h')
            {
                AcceptInput(1M);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 'k')
            {
                AcceptInput(1E3M);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 'm')
            {
                AcceptInput(1E6M);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 'g')
            {
                AcceptInput(1E9M);
                e.Handled = true;
                return;
            }
            e.Handled = AddChar(e.KeyChar);
        }

        private void FrequencyInputPad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                RemoveChar();
            }
            if (e.KeyCode == Keys.Enter)
            {
                AcceptInput(1M);
                e.Handled = true;
            }
        }

        private void hzInputButton_Click(object sender, EventArgs e)
        {
            AcceptInput(1M);
        }

        private void khzInputButton_Click(object sender, EventArgs e)
        {
            AcceptInput(1E3M);
        }

        private void mhzInputButton_Click(object sender, EventArgs e)
        {
            AcceptInput(1E6M);
        }

        private void ghzInputButton_Click(object sender, EventArgs e)
        {
            AcceptInput(1E9M);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valueTextBox.Text = "";
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            RemoveChar();
        }
    }
}
