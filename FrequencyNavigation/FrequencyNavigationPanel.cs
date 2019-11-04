using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SDRSharp.Common;

namespace SDRSharp.FrequencyNavigation
{
    [DesignTimeVisible(true)]
    [Category("SDRSharp")]
    [Description("Frequency navigation panel")]
    public partial class FrequencyNavigationPanel : UserControl
    {
        private readonly ISharpControl _control;
        private const int MaxOrder = 9;
        private int _order = 3;


        public FrequencyNavigationPanel(ISharpControl control)
        {
            InitializeComponent();

            _control = control;
            _control.PropertyChanged += ControlOnPropertyChanged;

            DisplayFrequency();

            var index = repeatIntervalComboBox.FindStringExact(
                stepUpButton.RepeatInterval.ToString(CultureInfo.InvariantCulture)
                );
            repeatIntervalComboBox.SelectedIndex = index;
        }

        
        private static long Pow(long value, int order)
        {
            if (order < 0)
            {
                throw new ArgumentException("Order must be more or equal to zero!", "order");
            }
            long result = 1L;
            int i = order;
            while (i > 0)
            {
                result *= value;
                i--;
            }
            return result;
        }

        private static string FrequencyString(long freq, int order)
        {
            var s = freq.ToString(CultureInfo.InvariantCulture).PadLeft(order + 1, '0');
            s = s.Insert(s.Length - order - 1, "[").Insert(s.Length - order + 1, "]");
            return s;
        }


        private void SetFrequency(long freq)
        {
            //_control.SetFrequency(freq, _control.SourceIsTunable);
            _control.Frequency = freq;
        }

        private void SetStepSize(long stepSize)
        {
            if (stepSize%1000000000L == 0)
            {
                stepSizeTextBox.Text = (stepSize / 1000000000L).ToString(CultureInfo.CurrentCulture) + "G";
                return;
            }
            if (stepSize % 1000000L == 0)
            {
                stepSizeTextBox.Text = (stepSize / 1000000L).ToString(CultureInfo.CurrentCulture) + "M";
                return;
            }
            if (stepSize % 1000L == 0)
            {
                stepSizeTextBox.Text = (stepSize / 1000L).ToString(CultureInfo.CurrentCulture) + "k";
                return;
            }
            stepSizeTextBox.Text = stepSize.ToString(CultureInfo.CurrentCulture);
        }

        private long ReadStepSize()
        {
            var stepSizeText = stepSizeTextBox.Text.ToUpper();
            long multiplier = 1L;
            while (stepSizeText.EndsWith("K") || stepSizeText.EndsWith("M") || stepSizeText.EndsWith("G"))
            {
                var lastChar = stepSizeText.Last();
                switch (lastChar)
                {
                    case 'K':
                        multiplier *= 1000;
                        break;
                    case 'M':
                        multiplier *= 1000 * 1000;
                        break;
                    case 'G':
                        multiplier *= 1000 * 1000 * 1000;
                        break;
                }
                stepSizeText = stepSizeText.Substring(0, stepSizeText.Length - 1);
            }
            double result;
            bool success =
                double.TryParse(stepSizeText, NumberStyles.Any, CultureInfo.CurrentCulture, out result) ||
                double.TryParse(stepSizeText, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
            return (success)
                       ? (long) (result*multiplier)
                       : 0L;
        }

        private void Step(long stepSize, bool increase)
        {
            if (!_control.IsPlaying) { return; }

            var freq = _control.Frequency;
            freq = (increase)
                       ? freq + stepSize
                       : freq - stepSize;
            SetFrequency(freq);
        }

        private void DisplayFrequency()
        {
            orderLabel.Text = FrequencyString(_control.Frequency, _order);
        }

        private void ChangeOrder(int delta)
        {
            var newWorldOrder = _order + delta;
            _order = (newWorldOrder > MaxOrder)
                         ? MaxOrder
                         : (newWorldOrder < 0)
                               ? 0
                               : newWorldOrder;
            DisplayFrequency();
        }


        private void ControlOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Frequency")
            {
                DisplayFrequency();
            }
        }

        private void stepDownButton_Click(object sender, EventArgs e)
        {
            if (stepDownButton.LastRepeatCount == 0)
            {
                Step(ReadStepSize(), false);
            }
        }

        private void stepDownButton_Repeat(object sender, EventArgs e)
        {
            Step(ReadStepSize(), false);
        }

        private void stepUpButton_Click(object sender, EventArgs e)
        {
            if (stepUpButton.LastRepeatCount == 0)
            {
                Step(ReadStepSize(), true);
            }
        }

        private void stepUpButton_Repeat(object sender, EventArgs e)
        {
            Step(ReadStepSize(), true);
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            if (increaseButton.LastRepeatCount == 0)
            {
                Step(Pow(10L, _order), true);
            }
        }

        private void increaseButton_Repeat(object sender, EventArgs e)
        {
            Step(Pow(10L, _order), true);
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            if (decreaseButton.LastRepeatCount == 0)
            {
                Step(Pow(10L, _order), false);
            }
        }

        private void decreaseButton_Repeat(object sender, EventArgs e)
        {
            Step(Pow(10L, _order), false);
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            ChangeOrder(1);
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            ChangeOrder(-1);
        }

        private void repeatIntervalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int repeatInterval;
            if (!int.TryParse(repeatIntervalComboBox.Text, out repeatInterval)) { return; }

            stepDownButton.RepeatInterval = repeatInterval;
            stepUpButton.RepeatInterval = repeatInterval;
            increaseButton.RepeatInterval = repeatInterval;
            decreaseButton.RepeatInterval = repeatInterval;
        }

        private void stepSizeTextBox_DoubleClick(object sender, EventArgs e)
        {
            var f = new FrequencyInputPad
            {
                Text = "Step size",
                AllowNegative = false,
                StartPosition = FormStartPosition.Manual
            };
            f.RelativeAlign(stepSizeTextBox, ContentAlignment.MiddleRight, 5);
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                SetStepSize((long) f.Value);
            }
        }

        private void orderLabel_DoubleClick(object sender, EventArgs e)
        {
            var f = new FrequencyInputPad
            {
                Text = "Frequency",
                AllowNegative = !_control.SourceIsTunable,
                StartPosition = FormStartPosition.Manual
            };
            f.RelativeAlign(orderLabel, ContentAlignment.MiddleRight, 5);
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                if (!_control.IsPlaying) { return; }
                SetFrequency((long)f.Value);
            }
        }
    }
}
