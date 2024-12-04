using System;
using Realms;

namespace BlackjackServer;

public class RealmAccess : IDisposable
{
    public static RealmAccess Instance { get; private set; } = new();
    private readonly Realm _realm;

    private RealmAccess()
    {
        var config = new RealmConfiguration("users.realm");
        _realm = Realm.GetInstance(config);
    }

    public void Dispose()
    {
        _realm.Dispose();
    }
}