using System;
using System.Collections.Concurrent;

public class OnlineUsersService
{
    private readonly ConcurrentDictionary<string, DateTime> _activeSessions = new ConcurrentDictionary<string, DateTime>();

    public void AddOrUpdateUser(string sessionId)
    {
        _activeSessions[sessionId] = DateTime.UtcNow;
    }

    public void RemoveUser(string sessionId)
    {
        _activeSessions.TryRemove(sessionId, out _);
    }

    public int GetOnlineUsersCount()
    {
        CleanExpiredSessions();
        return _activeSessions.Count;
    }

    private void CleanExpiredSessions()
    {
        foreach (var session in _activeSessions)
        {
            if (DateTime.UtcNow - session.Value > TimeSpan.FromSeconds(5)) 
            {
                _activeSessions.TryRemove(session.Key, out _);
            }
        }
    }
}
