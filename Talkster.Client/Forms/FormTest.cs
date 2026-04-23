using ReaLTaiizor.Forms;
using Talkster.Client.Controls.FlowControls;
using static Talkster.Library.ScConstants;

namespace Talkster.Client.Forms
{
    public partial class FormTest
        : PoisonForm
    {
        public FormTest()
        {
            InitializeComponent();

            Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;

            textBoxMessage.Text = $"This is message one. This is message two. This is message three. This is message four. This is message five. This is message six. This is message seven. This is message eight. This is message nine. This is message ten.";

            Resize += (s, e) =>
            {
                flowLayoutPanelChat.SuspendLayout();

                foreach (var child in flowLayoutPanelChat.Controls)
                {
                    if (child is FlowControlOriginBubble bubble && bubble.IsVisible)
                    {
                        bubble.Width = flowLayoutPanelChat.Width;
                    }
                }
                flowLayoutPanelChat.ResumeLayout();

                flowLayoutPanelChat.Invalidate(true);
            };

            buttonSend.Focus();
            this.AcceptButton = buttonSend;
        }

        private void AddChatBubble(string displayName, ScOrigin origin, string message)
        {
            var bubble = new FlowControlHyperlink(flowLayoutPanelChat, message, origin, null, displayName);
            flowLayoutPanelChat.Controls.Add(bubble);
            flowLayoutPanelChat.VerticalScroll.Value = flowLayoutPanelChat.VerticalScroll.Maximum;
        }

        int number = 0;

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            ScOrigin origin = ScOrigin.None;
            string displayName = "Test User";

            if (number++ % 2 == 0)
            {
                displayName = "Josh";
                origin = ScOrigin.Local;
            }
            else
            {
                displayName = "George";
                origin = ScOrigin.Remote;
            }



            AddChatBubble(displayName, origin, textBoxMessage.Text);
        }
    }
}
