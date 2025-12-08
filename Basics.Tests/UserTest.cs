using Basics_0.Models;
using Xunit;

namespace Basics.Test
{
    public class UserTest
    {
        [Fact]
        public void GetInfo_WithValidValue_ReturnUerInfo()
        {
            int id = 1;
            string name = "Kostya_is_great";
            string email = "email@email.ru";
            
            User user = new User(id,  name, email);
            user.SetEmail(email);
            
            Assert.Equal("User: Kostya_is_great, ID: 1", user.GetInfo());
        }
    }
}