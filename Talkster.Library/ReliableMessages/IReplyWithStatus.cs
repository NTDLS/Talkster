using NTDLS.ReliableMessaging;

namespace Talkster.Library.ReliableMessages
{
    public interface IReplyWithStatus
        : IRmQueryReply
    {
        bool IsSuccess { get; }
        string? ErrorMessage { get; }
    }
}
