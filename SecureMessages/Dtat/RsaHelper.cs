namespace Dtat;

public static class RsaHelper : object
{
	static RsaHelper()
	{
	}

	public static RsaKeyPems GenerateRsaPemKeys
		(int keySize = 4096, string? password = null)
	{
		using var rsa = new System.Security
			.Cryptography.RSACryptoServiceProvider(dwKeySize: keySize);

		string publicKeyPem;
		string privateKeyPem;

		if (string.IsNullOrWhiteSpace(value: password))
		{
			publicKeyPem = rsa.ExportRSAPublicKeyPem();
			privateKeyPem = rsa.ExportRSAPrivateKeyPem();
		}
		else
		{
			publicKeyPem = rsa.ExportRSAPublicKeyPem();
			privateKeyPem = rsa.ExportRSAPrivateKeyPem();
		}

		var result = new RsaKeyPems
			(PrivateKeyPem: privateKeyPem, PublicKeyPem: publicKeyPem);

		return result;
	}

	public static string Encrypt
		(string plainText, string publicKeyPem)
	{
		using var rsa = new System.Security
			.Cryptography.RSACryptoServiceProvider();

		rsa.ImportFromPem(input: publicKeyPem);

		var plainTextBytes = System.Text
			.Encoding.UTF8.GetBytes(s: plainText);

		var encryptedTextBytes =
			rsa.Encrypt(rgb: plainTextBytes, fOAEP: false);

		var encryptedBase64String = System.Convert
			.ToBase64String(inArray: encryptedTextBytes);

		return encryptedBase64String;
	}

	public static string Decrypt
		(string encryptedBase64String, string privateKeyPem)
	{
		using var rsa = new System.Security
			.Cryptography.RSACryptoServiceProvider();

		rsa.ImportFromPem(input: privateKeyPem);

		var encryptedDataBytes = System.Convert
			.FromBase64String(s: encryptedBase64String);

		var plainTextBytes =
			rsa.Decrypt(rgb: encryptedDataBytes, fOAEP: false);

		var plainText = System.Text.Encoding
			.UTF8.GetString(bytes: plainTextBytes);

		return plainText;
	}
}
