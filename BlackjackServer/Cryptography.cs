using System;
using System.Linq;
using System.Security.Cryptography;

namespace BlackjackServer;

public class Cryptography : IDisposable
{
    public static Cryptography Instance { get; } = new();
    private SHA256 Sha256 { get; } = SHA256.Create();

    public (byte[], byte[]) SaltHash(byte[] hash)
    {
        var salt = GenerateSalt();
        var hashAsList = hash.ToList();
        hashAsList.AddRange(salt.ToList());
        return (salt, hashAsList.ToArray());
    }

    private byte[] GenerateSalt()
    {
        // 16 bytes = 64 bits
        // array of 16 bytes required
        var salt = new byte[16];
        RandomNumberGenerator.Fill(salt);
        return salt;
    }

    public void Dispose()
    {
        Sha256.Dispose();
    }
}