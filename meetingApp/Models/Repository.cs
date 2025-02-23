using System;
using MeetingApp.Models;

namespace meetingApp.Models;

public static class Repository
{
    public static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo()
        {
            Id = 1,
            Name = "Harun Doğdu",
            Email = "harundogdu@hd.com",
            Phone = "1234567890",
            WillAttend = true
        });
        _users.Add(new UserInfo()
        {
            Id = 2,
            Name = "Muhammed Emin Beköz",
            Email = "mami@hd.com",
            Phone = "1451567890",
            WillAttend = true
        });
        _users.Add(new UserInfo()
        {
            Id = 3,
            Name = "Ahmet Enes Bahar",
            Email = "amedenez@hd.com",
            Phone = "1451567880",
            WillAttend = true
        });
    }

    public static List<UserInfo> Users
    {
        get
        {
            return _users;
        }
    }

    public static void CreateUser(UserInfo user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
    }
}
