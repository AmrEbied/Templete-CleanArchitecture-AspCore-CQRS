namespace Web.PathUrl
{
    public class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Identity
        {

            public const string Register = Base + "/Register";
            public const string Login = Base + "/Login";
            public const string ForgetPassword = Base + "/ForgetPassword";
            public const string ChangePassword = Base + "/ChangePassword";
            public const string RefreshToken = Base + "/RefreshToken";
            public const string RevokeToken = Base + "/RevokeToken";
            public const string SendCode = Base + "/SendCode";

        }
    }
}
