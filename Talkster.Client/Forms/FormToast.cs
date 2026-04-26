using ReaLTaiizor.Forms;
using static Talkster.Client.Helpers.Notifications;

namespace Talkster.Client.Forms
{
    public partial class FormToast
        : PoisonForm
    {
        public delegate void ToastClickActionParameterized(object? param);
        public delegate void ToastClickAction();

        private int _duration = 0;
        private System.Windows.Forms.Timer _timer = new();
        private DateTime _startTimeUTC;

        private ToastClickActionParameterized? _parameterizedAction;
        private ToastClickAction? _action;
        private object? _actionParameter;
        private bool _closing = false;

        public FormToast()
        {
            InitializeComponent();
            Theming.SetupTheme(this);

            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            Opacity = 0;
            Padding = new Padding(10);

            _timer.Tick += Timer_Tick;
            _timer.Interval = 10;

            Click += FormToast_Click;
            labelBody.Click += FormToast_Click;
            labelHeader.Click += FormToast_Click;
            pictureBoxIcon.Click += FormToast_Click;

            labelHeader.Top = 10;
            labelHeader.Left = pictureBoxIcon.Right;

            labelBody.Left = pictureBoxIcon.Right;
            labelBody.Top = labelHeader.Bottom + 5;
            labelBody.Height = this.Height - labelBody.Top;
            labelBody.Width = this.Width - labelBody.Left - 10;

            this.FormClosing += FormToast_FormClosing;

            _closing = false;
        }

        private void FormToast_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!_closing)
            {
                _startTimeUTC = DateTime.UtcNow.AddMilliseconds(-_duration);
                e.Cancel = true; //Cancel the close, we'll hide it after the fade-out completes.
            }
        }

        public void InvokePopup(ToastStyle style, string headerText, string bodyText,
            ToastClickActionParameterized? action, object actionParameter, int duration = 3000, ToastPosition position = ToastPosition.BottomRight)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => InvokePopup(style, headerText, bodyText, action, actionParameter, duration, position)));
                return;
            }

            if (Visible)
            {
                return; //If the toast is already visible, just exit.
            }

            _parameterizedAction = action;
            _actionParameter = actionParameter;
            _action = null;

            Popup(style, headerText, bodyText, duration, position);
        }

        public void InvokePopup(ToastStyle style, string headerText, string bodyText,
            ToastClickAction? action, int duration = 3000, ToastPosition position = ToastPosition.BottomRight)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => InvokePopup(style, headerText, bodyText, action, duration, position)));
                return;
            }

            if (Visible)
            {
                return; //If the toast is already visible, just exit.
            }

            _parameterizedAction = null;
            _actionParameter = null;
            _action = action;

            Popup(style, headerText, bodyText, duration, position);
        }

        private void Popup(ToastStyle style, string headerText, string bodyText, int duration = 3000, ToastPosition position = ToastPosition.BottomRight)
        {
            Opacity = 0;
            _closing = false;

            _duration = duration;

            labelHeader.BackColor = Color.Transparent;
            labelHeader.Text = headerText;

            labelBody.ForeColor = labelHeader.ForeColor;
            labelBody.BackColor = Color.Transparent;
            labelBody.Text = bodyText;

            switch (style)
            {
                case ToastStyle.Error:
                    pictureBoxIcon.Image = Properties.Resources.ToastError32;
                    break;
                case ToastStyle.Success:
                    pictureBoxIcon.Image = Properties.Resources.ToastSuccess32;
                    break;
                case ToastStyle.Warning:
                    pictureBoxIcon.Image = Properties.Resources.ToastWarning32;
                    break;
                default:
                    pictureBoxIcon.Image = Properties.Resources.AppLogo32;
                    break;
            }

            var screen = GetCurrentScreen();
            switch (position)
            {
                case ToastPosition.TopLeft:
                    Location = new Point(screen.WorkingArea.Left + 10, screen.WorkingArea.Top + 10);
                    break;
                case ToastPosition.TopRight:
                    Location = new Point(screen.WorkingArea.Right - Width - 10, screen.WorkingArea.Top + 10);
                    break;
                case ToastPosition.TopCenter:
                    Location = new Point(screen.WorkingArea.Left + (screen.WorkingArea.Width / 2) - (Width / 2), screen.WorkingArea.Top + 10);
                    break;
                case ToastPosition.BottomLeft:
                    Location = new Point(screen.WorkingArea.Left + 10, screen.WorkingArea.Bottom - Height - 10);
                    break;
                case ToastPosition.BottomRight:
                    Location = new Point(screen.WorkingArea.Right - Width - 10, screen.WorkingArea.Bottom - Height - 10);
                    break;
                case ToastPosition.BottomCenter:
                    Location = new Point(screen.WorkingArea.Left + (screen.WorkingArea.Width / 2) - (Width / 2), screen.WorkingArea.Bottom - Height - 10);
                    break;
            }

            Show();

            _startTimeUTC = DateTime.UtcNow;
            _timer.Start();
            _timer.Enabled = true;
        }

        private void FormToast_Click(object? sender, EventArgs e)
        {
            //Trigger the fade-out immediately.
            _startTimeUTC = DateTime.UtcNow.AddMilliseconds(-_duration);

            _action?.Invoke();
            _parameterizedAction?.Invoke(_actionParameter);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (Visible == false)
            {
                _timer.Stop();
                return;
            }

            if ((DateTime.UtcNow - _startTimeUTC).TotalMilliseconds > _duration)
            {
                if (Opacity == 0)
                {
                    _timer.Stop();
                    _closing = true;
                    Hide();
                }
                else
                {
                    Opacity -= 0.1f;
                }
            }
            else if (Opacity < 1.0f)
            {
                Opacity += 0.1f;
            }
            else
            {
                //Just showing the dialog, waiting on the fade-out to start.
            }
        }

        private Screen GetCurrentScreen()
        {
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.Bounds.Contains(Location))
                {
                    return screen;
                }
            }

            return Screen.AllScreens.First();
        }
    }
}
