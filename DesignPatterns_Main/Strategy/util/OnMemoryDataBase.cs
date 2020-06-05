using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.util
{
    public static class OnMemoryDataBase
    {
        private static Dictionary<string, User> USER_MAP = new Dictionary<string, User>();

        static OnMemoryDataBase()
        {
            USER_MAP.Add("oblancarte", new User() {  userId = 1, name = "Oscar Blancarte", pwd = "1231" ,rol="Admin"});
            USER_MAP.Add("jblancarte", new User() { userId = 2, name = "Juan Blancarte", pwd = "1232",rol="Cajero" });
            USER_MAP.Add("gblancarte", new User() { userId = 3, name = "Guilon Blancarte", pwd = "1233",rol="Supervisor" });
            USER_MAP.Add("lblancarte", new User() { userId = 4, name = "Luis Blancarte", pwd = "1234",rol="Guardia" });
        }

        public static User findUserById(string userName)
        {
            return USER_MAP.GetValueOrDefault(userName);
        }
    }
}
