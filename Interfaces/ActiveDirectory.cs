using System;

namespace GuildfordBoroughCouncil.ActiveDirectory.Interfaces
{
    public interface IObject
    {
        /// <summary>
        /// The down-level logon name for the object.
        /// </summary>
        string UserName { get; set; }
        /// <summary>
        /// The account name or logon name for the object.
        /// </summary>
        string UserNameX { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string PhotoUrl { get; set; }
    }

    public interface IGroup : IObject
    {
        string Description { get; set; }
    }

    public interface IUser : IObject
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Title { get; set; }
        string Department { get; set; }
        string Office { get; set; }
        /// <summary>
        /// The down-level logon name for the user's manager.
        /// </summary>
        string ManagerUserName { get; set; }
        /// <summary>
        /// The user account name or logon name for the user's manager.
        /// </summary>
        string ManagerUserNameX { get; set; }
        int DirectReports { get; set; }
        string Telephone { get; set; }
        string TelephoneXtn { get; set; }
    }
}
