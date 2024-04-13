namespace Framework2.Service
{
    public static class ControleAcesso
    {
        private static bool loginRealizado { get; set; }
        public static void Login(string usuario, string senha)
        {
            loginRealizado = (usuario == "Lkz" && senha == "123");
        }

        public static bool RetornaLoginRealizado()
        {
            return loginRealizado;
        }
    }
}
