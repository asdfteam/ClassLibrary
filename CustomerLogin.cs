using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelLibrary
{
    public class CustomerLogin
    {
        [ForeignKey("customer_id")]
        public int Id { get; }
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }

        public CustomerLogin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}