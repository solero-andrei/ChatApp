using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using ChatApp_Model;
using ChatApp_Controller;

namespace ChatApp_Project
{
    public class _FormMessagingProcessor
    {
        private readonly MessageModel message;
        private FlowLayoutPanel MessagesContainer { get; }
        private IMessageModel Messaging { get; }

        public _FormMessagingProcessor(FlowLayoutPanel messagesContainer, MessageModel message, IMessageModel messaging)
        {
            MessagesContainer = messagesContainer;
            this.message = message;
            Messaging = messaging;
        }        

        private void GetMessagingForm(UserControl form)
        {
            MessagesContainer.Controls.Add(form);
            MessagesContainer.ScrollControlIntoView(form);

            MessagesContainer.AutoScrollPosition = new Point(
                               form.Right - MessagesContainer.AutoScrollPosition.X,
                               form.Bottom - MessagesContainer.AutoScrollPosition.Y);
        }

        public void MessagingFormValidation(UserControl formSentImage, UserControl formSent, UserControl formReceivedImage, UserControl formReceived)
        {
            if (message.MessageFrom.UserID == Messaging.MessageFrom.UserID)
            {
                if (message.MessageContent.Substring(0, 3) == "img")
                {
                    formSentImage = new MessageSentImage(message);
                    GetMessagingForm(formSentImage);
                }
                else
                {
                    formSent = new MessageSent(message);
                    GetMessagingForm(formSent);
                }

            }
            else
            {
                if (message.MessageContent.Substring(0, 3) == "img")
                {
                    formReceivedImage = new MessageReceivedImage(message);
                    GetMessagingForm(formReceivedImage);
                }
                else
                {
                    formReceived = new MessageReceived(message);
                    GetMessagingForm(formReceived);
                }
            }
        }

    }
}
