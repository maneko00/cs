using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public sealed class UserInfoDTO
    {
        public UserInfoDTO(
            string id,
            string mailSend,
            string mailAddress,
            string plan,
            string enableText)
        {
            Id = id;
            MailSend = mailSend;
            MailAddress = mailAddress;
            Plan = plan;
            EnableText = enableText;
        }

        public string Id { get; }
        public string MailSend { get; }
        public string MailAddress { get; }
        public string Plan { get; }
        public string EnableText { get; }
    }
}
