namespace Email.API.Configuration
{
    public static class SmtpSettings
    {

        public static string Host = "smtp-relay.sendinblue.com";
        public static int Port = 587;
        public static string UserName = "gorgino2020@gmail.com";
        public static string Password = "EnA8LhBUQCOMXKTw";
        public static bool EnableSsl = false;
        public static string FromAddress = "gorgino2020@gmail.com";
        public static string FromDisplayName = "Support";
        public static string ToAddress = "support_floward@mailinator.com";
        public static bool IsHtml = true;
    }
}
