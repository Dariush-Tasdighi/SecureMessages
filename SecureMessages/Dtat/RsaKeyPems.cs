namespace Dtat;

//public class RsaKeyPems : object
//{
//	public string? PublicKeyPem { get; set; }

//	public string? PrivateKeyPem { get; set; }
//}

//public class RsaKeyPems : object
//{
//	public RsaKeyPems(string privateKeyPem, string publicKeyPem)
//	{
//		PublicKeyPem = publicKeyPem;
//		PrivateKeyPem = privateKeyPem;
//	}

//	public string PublicKeyPem { get; private set; }

//	public string PrivateKeyPem { get; private set; }
//}

//public class RsaKeyPems(string privateKeyPem, string publicKeyPem) : object
//{
//	public string PublicKeyPem { get; private set; } = publicKeyPem;

//	public string PrivateKeyPem { get; private set; } = privateKeyPem;
//}

public record RsaKeyPems(string PrivateKeyPem, string PublicKeyPem) : object;
