using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group_4_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_4_DB.Controllers;

namespace Group_4_DB.Tests
{
    [TestClass()]
    public class JWAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
             JWAuthenticationManager manager = new JWAuthenticationManager("fakaelogin");

            User user = new User
            {
                username = "test",
                password= "pass"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }
    }
}