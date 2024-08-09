using BoTechDevelopment.API_Models.Software;

namespace BoTechDevelopment.API_Models.LoginSystem
{

    public class User : ICloneable
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

        public DateTime Registered { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string VeriCode { get; set; } = string.Empty;
        public DateTime VeriCodeGenerated { get; set; }
        public EUserStatus Status { get; set; } = EUserStatus.None;
        public List<UserComputer> UserComputers { get; set; } = new List<UserComputer>();
        public List<Session> ConnectedSessions{ get; set; } = new List<Session>();
        public List<SoftwareProduct> BuyedProducts { get; set; } = new();
        public User()
        {

        }

        public User(int id, string name, string lastName, string nickName, string eMail, string phoneNumber, DateOnly birthday, int houseNumber, char houseIndex, int pLZ, string street, string city, string state, string country, DateTime registered, string password, string salt, string veriCode, DateTime veriCodeGenerated, EUserStatus status, List<UserComputer> userComputers, List<Session> connectedSessions)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            NickName = nickName;
            EMail = eMail;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            HouseNumber = houseNumber;
            HouseIndex = houseIndex;
            PLZ = pLZ;
            Street = street;
            City = city;
            State = state;
            Country = country;
            Registered = registered;
            Password = password;
            Salt = salt;
            VeriCode = veriCode;
            VeriCodeGenerated = veriCodeGenerated;
            Status = status;
            UserComputers = userComputers;
            ConnectedSessions = connectedSessions;
        }

        public object Clone()
        {
            User user = new User();
            user.Id = Id;
            user.Name = (string)Name.Clone();
            user.LastName = (string)LastName.Clone();
            user.NickName = (string)NickName.Clone();
            user.EMail = (string)EMail.Clone();
            user.PhoneNumber = (string)PhoneNumber.Clone();
            user.Birthday = Birthday;
            user.HouseNumber = HouseNumber;
            user.HouseIndex = HouseIndex;
            user.PLZ = PLZ;
            user.Street = (string)Street.Clone();
            user.City = (string)City.Clone();
            user.State = (string)State.Clone();
            user.Country = (string)Country.Clone();
            user.Registered = Registered;
            user.Password = (string)Password.Clone();
            user.Salt = (string)Salt.Clone();   
            user.VeriCode = (string)VeriCode.Clone();
            user.VeriCodeGenerated = VeriCodeGenerated;
            user.Status = Status;
            user.UserComputers = UserComputers;
            user.ConnectedSessions = ConnectedSessions;
            return user;
        }
    }
}
