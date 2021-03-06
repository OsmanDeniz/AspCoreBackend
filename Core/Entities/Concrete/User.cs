namespace Core.Entities.Concrete
{
    /// <summary>
    /// Burada entity olusturulmasinin nedeni diger projelerde de ayni islemler yapilabilecegi icin
    /// 
    /// </summary>
    public class User : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public bool Status { get; set; }
    }
}
