namespace FTPDownloader.BusinessLogicLayer
{
    using System;

    public class FTPAccessData
    {
        public FTPAccessData(int id, string name, string gln, string login, string pass)
        {
            this.ID = id;
            this.ShopName = name;
            this.GLN = gln;
            this.Login = login;
            this.Password = pass;
        }

        public int ID { get; private set; }
        public string ShopName { get; set; }
        public string GLN { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
