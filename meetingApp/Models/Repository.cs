using System;
using MeetingApp.Models;

namespace meetingApp.Models;

public static class Repository
{
    public static List<UserInfo> _users = new();

    public static List<UserInfo> Users
    {
        get
        {
            return _users;
        }
    }

    public static void CreateUser(UserInfo user)
    {
        _users.Add(user);
    }
}
