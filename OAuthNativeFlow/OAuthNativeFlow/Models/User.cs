using System;
using Xamarin.Forms;

namespace OAuthNativeFlow.Models
{
    public class User
    {
        public string Username { get; set; }
        public ImageSource PhotoProfil { get; set; }
        public ushort Sid9 { get; set; }

        public static implicit operator User(OAuthNativeFlow.User v)
        {
            throw new NotImplementedException();
        }
    }
}
