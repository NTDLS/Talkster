﻿using NTDLS.ReliableMessaging;

namespace Talkster.Library.ReliableMessages
{
    /// <summary>
    /// Tells the remote peer that the file transfer was fully received.
    /// </summary>
    public class FileTransferAcknowledgmentNotification
        : IRmNotification
    {
        public Guid FileId { get; set; }

        /// <summary>
        /// The connection id of the remote peer that this message is being sent to.
        /// </summary>
        public Guid PeerConnectionId { get; set; }

        /// <summary>
        /// Identifies this chat session. This is used to identify the chat session when sending messages.
        /// If the session is ended and a new one is started, it will have a different SessionId - even if it is the same contact.
        /// </summary>
        public Guid SessionId { get; set; }

        public FileTransferAcknowledgmentNotification(Guid sessionId, Guid peerConnectionId, Guid fileId)
        {
            SessionId = sessionId;
            PeerConnectionId = peerConnectionId;
            FileId = fileId;
        }
    }
}
