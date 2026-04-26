using Talkster.Library.ReliableMessages;

namespace Talkster.Library
{
    public static class QueryReplyExtensions
    {
        public static T ThrowIfFailed<T>(this T reply) where T : IReplyWithStatus
        {
            if (!reply.IsSuccess) throw new Exception(reply.ErrorMessage);
            return reply;
        }
    }
}
