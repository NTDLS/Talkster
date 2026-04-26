using NTDLS.ReliableMessaging;

namespace Talkster.Library.ReliableMessages
{
    public class UpdateAccountPasswordQuery
        : IRmQuery<UpdateAccountPasswordQueryReply>
    {
        public string PasswordHash { get; set; } = string.Empty;

        public UpdateAccountPasswordQuery(string passwordHash)
        {
            PasswordHash = passwordHash;
        }
    }

    public class UpdateAccountPasswordQueryReply
        : IReplyWithStatus
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }

        public UpdateAccountPasswordQueryReply(Exception exception)
        {
            ErrorMessage = exception.GetBaseException().Message;
            IsSuccess = false;
        }

        public UpdateAccountPasswordQueryReply()
        {
            IsSuccess = true;
        }
    }
}
