namespace _2048WinFormsApp
{
    public class User
    {
        protected string _name { get;}
        public int _score { get; set; }
        public User(string Name)
        {
            _name = Name;
        }
    }
}
