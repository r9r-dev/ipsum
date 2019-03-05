namespace ipsum.data
{
    public class Persona
    {
        public string FirstName;
        public string LastName;
        public string Username => $"{FirstName.ToLower().Substring(0, 1)}{FirstName.Length + LastName.Length - 2}{LastName.ToLower()[LastName.Length - 1]}";
        public string Email => $"{FirstName.ToLower()}.{LastName.ToLower()}@yopmail.com";
    }
}