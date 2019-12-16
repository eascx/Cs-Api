using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public UserPram userPram { get; set; }
    }
    public enum UserPram
    {
        IS_CREATE=1,
        IS_ROOT = 1<<1,
        IS_ACTIVATION = 1 << 2,
        IS_BANDE = 1 << 3,
        IS_EDITOR = 1 << 4
    }
}
