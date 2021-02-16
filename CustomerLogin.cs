namespace HotelLibrary
{
    public class CustomerLogin
    {
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }

        public CustomerLogin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}