using System;
using System.Runtime.Serialization;

namespace GuildfordBoroughCouncil.ActiveDirectory.Models
{
    [DataContract]
    public partial class Object
    {
        /// <summary>
        /// The down-level logon name for the object.
        /// </summary>
        [DataMember]
        public string UserName { get; set; }
        /// <summary>
        /// The account name or logon name for the object.
        /// </summary>
        [DataMember]
        public string UserNameX { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PhotoUrl { get; set; }
    }

    [DataContract]
    public partial class Group : Object
    {
        public Group() { }

        [DataMember]
        public string Description { get; set; }
    }

    [DataContract]
    public partial class User : Object
    {
        public User() { }

        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public string Office { get; set; }
        /// <summary>
        /// The down-level logon name for the user's manager.
        /// </summary>
        [DataMember]
        public string ManagerUserName { get; set; }
        /// <summary>
        /// The user account name or logon name for the user's manager.
        /// </summary>
        [DataMember]
        public string ManagerUserNameX { get; set; }
        [DataMember]
        public int DirectReports { get; set; }
        [DataMember]
        public string Telephone { get; set; }
        [DataMember]
        public string TelephoneXtn { get; set; }
    }
}
