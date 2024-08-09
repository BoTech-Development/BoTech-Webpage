using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;



namespace BoTechDevelopment.Models.LoginSystem.Backend
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;

        public string PhoneNumber {  get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public int HouseNumber { get; set; }
        public char HouseIndex { get; set; } = 'a';
        public int PLZ { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public DateTime registered { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string VeriCode { get; set; } = string.Empty;
        public DateTime VeriCodeGenerated { get; set; }
        public EUserStatus Status { get; set; } = EUserStatus.None;
        public List<UserComputer> userComputers { get; } = new List<UserComputer>();
        public List<Session> connectedSessions{ get; set; } = new List<Session>();
        public User()
        {

        }

        public User(int id, string name, string lastName, string nickName, string eMail, DateTime registered, string password, string salt, string veriCode, EUserStatus status, List<UserComputer> userComputers, List<Session> connectedSessions)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            NickName = nickName ?? throw new ArgumentNullException(nameof(nickName));
            EMail = eMail ?? throw new ArgumentNullException(nameof(eMail));
            this.registered = registered;
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Salt = salt ?? throw new ArgumentNullException(nameof(salt));
            VeriCode = veriCode ?? throw new ArgumentNullException(nameof(veriCode));
            Status = status;
            this.userComputers = userComputers ?? throw new ArgumentNullException(nameof(userComputers));
            this.connectedSessions = connectedSessions;
        }
    }
}
