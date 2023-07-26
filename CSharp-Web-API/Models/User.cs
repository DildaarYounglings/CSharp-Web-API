namespace CSharp_Web_API.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public User(int _id, string _name, string _email)
        {
            id = _id;
            name = _name;
            email = _email;
        }

        internal void Deconstruct(out int _id, out string _name, out string _email)
        {
            _id = id; _name = name; _email = email;
        }
    }
}
