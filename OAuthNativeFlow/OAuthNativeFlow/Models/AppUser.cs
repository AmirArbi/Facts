using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace OAuthNativeFlow.Models
{
    public class AppUser
    {
        private static string username;
        private static ImageSource photoProfil;
        private static ushort sid9;
        private static string email;

        public static string GetUserName()
        {
            return username;
        }
        public static void SetUserName(string UserName)
        {
            username = UserName;
        }
        public static string GetEmail()
        {
            return email;
        }
        public static void SetEmail(string Email)
        {
            username = email;
        }
        public static ImageSource GetPhotoProfil()
        {
            return photoProfil;
        }
        public static void SetPhotoProfil(ImageSource PhotoProfil)
        {
            photoProfil = PhotoProfil;
        }

        internal static void SetUserName(object p)
        {
            throw new NotImplementedException();
        }

        public static ushort GetSid9()
        {
            return sid9;
        }
        public static void SetSid9(ushort Sid9)
        {
            sid9 = Sid9;
        }

    }
}
