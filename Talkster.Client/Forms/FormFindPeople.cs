using NTDLS.WinFormsHelpers;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using Talkster.Library;
using Talkster.Library.Models;
using Talkster.Library.ReliableMessages;

namespace Talkster.Client.Forms
{
    public partial class FormFindPeople
        : PoisonForm
    {
        private readonly Button _cancelButton;

        public FormFindPeople()
        {
            InitializeComponent();

            Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;

            _cancelButton = new Button();
            _cancelButton.Click += CancelButton_Click;

            AcceptButton = buttonSearch;
            CancelButton = _cancelButton;

            dataGridViewAccounts.CellContentClick += DataGridViewAccounts_CellContentClick;
        }

        private void DataGridViewAccounts_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ServerConnection.Current?.Connection.Client.IsConnected != true)
                {
                    MessageBox.Show("Connection to the server was lost.", ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.InvokeClose(DialogResult.Cancel);
                    return;
                }

                if (e.RowIndex >= 0 && dataGridViewAccounts.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (dataGridViewAccounts.Rows[e.RowIndex].Tag is AccountSearchModel account)
                    {
                        if (dataGridViewAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() == "Invite")
                        {
                            dataGridViewAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Sending";

                            ServerConnection.Current.Connection.Client.Query(new InviteContactQuery(account.Id));
                            Invoke(() =>
                            {
                                dataGridViewAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Remove";
                            });

                            ServerConnection.Current.FormHome.Repopulate();
                        }
                        else if (dataGridViewAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() == "Remove")
                        {
                            dataGridViewAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Removing";

                            ServerConnection.Current.Connection.Client.Query(new RemoveContactQuery(account.Id));
                            Invoke(() =>
                            {
                                dataGridViewAccounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Invite";
                            });
                            ServerConnection.Current.FormHome.Repopulate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error($"Error in {new StackTrace().GetFrame(0)?.GetMethod()?.Name ?? "Unknown"}.", ex);
                MessageBox.Show(ex.Message, ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServerConnection.Current?.Connection.Client.IsConnected != true)
                {
                    MessageBox.Show("Connection to the server was lost.", ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.InvokeClose(DialogResult.Cancel);
                    return;
                }

                var displayName = textBoxDisplayName.Text;

                dataGridViewAccounts.Rows.Clear();

                if (string.IsNullOrEmpty(displayName))
                {
                    return;
                }

                var results = ServerConnection.Current.Connection.Client.Query(new AccountSearchQuery(displayName));
                Invoke(() =>
                {
                    foreach (var account in results.Accounts)
                    {
                        var button = new DataGridViewButtonCell();

                        if (account.Id == ServerConnection.Current.AccountId)
                        {
                            button.Value = "You";
                        }
                        else if (account.IsExitingContact)
                        {
                            button.Value = "Remove";
                        }
                        else
                        {
                            button.Value = "Invite";
                        }

                        var row = new DataGridViewRow()
                        {
                            Tag = account
                        };
                        row.Cells.AddRange(
                            new DataGridViewTextBoxCell { Value = account.DisplayName },
                            new DataGridViewTextBoxCell { Value = account.State },
                            button
                        );

                        dataGridViewAccounts.Rows.Add(row);
                    }
                });

            }
            catch (Exception ex)
            {
                Program.Log.Error($"Error in {new StackTrace().GetFrame(0)?.GetMethod()?.Name ?? "Unknown"}.", ex);
                MessageBox.Show(ex.Message, ScConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
