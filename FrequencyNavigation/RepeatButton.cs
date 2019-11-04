using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SDRSharp.FrequencyNavigation
{
    /// <summary>
    /// Button, which raises additional event periodically while it is held down.
    /// </summary>
    /// <remarks>
    /// Mouse operation:
    ///    Raise <c>Repeat</c> event by timer, while left mouse button is down.
    ///    You can check <c>LastRepeatCount</c> later inside <c>Click</c> event handler
    ///    to see if there were repeats.
    /// Keyboard operation:
    ///    Timer not activated. <c>LastRepeatCount</c> is reset.
    ///    Return key sends Click events repeatedly on it's own.
    ///    They're seen as independent clicks.
    /// </remarks>
    public sealed class RepeatButton : Button
    {
        #region Fields

        private readonly Timer _timer;
        private bool _firstRun;

        #endregion


        #region Constructor

        public RepeatButton()
        {
            Delay = 500;
            RepeatInterval = 250;

            _timer = new Timer();
            _timer.Tick += TimerOnTick;
        }

        #endregion


        #region Properties

        [Description("Initial delay time in milliseconds.")]
        [DefaultValue(500)]
        public int Delay { get; set; }

        [Description("Interval between repetitions in milliseconds.")]
        [DefaultValue(250)]
        public int RepeatInterval { get; set; }

        [ReadOnly(true)]
        [Browsable(false)]
        public bool Pressed { get; private set; }

        /// <summary>
        /// Number of <c>Repeat</c> events while button was held down.
        /// </summary>
        [ReadOnly(true)]
        [Browsable(false)]
        public int LastRepeatCount { get; private set; }

        #endregion


        #region Events

        [Category("Action")]
        [Description("Occurs periodically while button is held down.")]
        public event EventHandler Repeat;

        private void OnRepeat()
        {
            Repeat?.Invoke(this, new EventArgs());
        }

        #endregion


        #region Event Handlers

        private void TimerOnTick(object sender, EventArgs e)
        {
            if (_firstRun)
            {
                _timer.Interval = RepeatInterval;
                _firstRun = false;
            }
            LastRepeatCount++;
            OnRepeat();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                LastRepeatCount = 0;
                Pressed = true;
                _firstRun = true;
                _timer.Interval = Delay;
                _timer.Start();
            }
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            Pressed = false;
            _timer.Stop();
            base.OnMouseUp(mevent);
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            LastRepeatCount = 0;
            base.OnPreviewKeyDown(e);
        }

        #endregion
    }
}
