namespace Blog {
	public static class Configuration {
        // TOKEN - JWT - Json Web Token
        public static string JwtKey = "M2E1ZDEyMjUtZjUzOC00ZGFmLWI0MzEtNjBkNjNmMjhkNTRk";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";
        public static SmtpConfiguration Smpt = new();

        public class SmtpConfiguration {
            public string Host { get; set; }
            public int Port { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}