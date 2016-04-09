Imports System.Security.Cryptography
Imports System.Text.Encoding
Imports System.IO

Public Class EncryptionWrapper

    Private _transform As ICryptoTransform
    Private _cipher As RijndaelManaged
    Private _key As Byte()
    Private _IV As Byte()

    Public Sub InitializeCipher(ByVal PW As String)
        _cipher = New RijndaelManaged
        _cipher.Mode = CipherMode.CBC
        _cipher.BlockSize = 128
        _cipher.KeySize = 256
        _cipher.Padding = PaddingMode.PKCS7
        _key = CreateKey(PW)
        _IV = CreateIV(PW)
    End Sub

    Public Sub InitializeCipher(ByVal key As String, ByVal iv As String)
        _cipher = New RijndaelManaged
        _cipher.Mode = CipherMode.CBC
        _cipher.BlockSize = 128
        _cipher.KeySize = 256
        _cipher.Padding = PaddingMode.PKCS7
        _key = System.Text.Encoding.Default.GetBytes(key)
        _IV = System.Text.Encoding.Default.GetBytes(iv)
    End Sub

    Public Function Encrypt(ByVal clearText As Byte()) As Byte()
        _transform = _cipher.CreateEncryptor(_key, _IV)
        Dim cipherText As Byte() = _transform.TransformFinalBlock(clearText, 0, clearText.Length)
        Return cipherText
    End Function

    Public Function Decrypt(ByVal cipherText As Byte()) As Byte()
        _transform = _cipher.CreateDecryptor(_key, _IV)
        Dim clearText As Byte() = _transform.TransformFinalBlock(cipherText, 0, cipherText.Length)
        Return clearText
    End Function

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        Dim chrData() As Char = strPassword.ToCharArray()
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte

        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        Dim SHA512 As New SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytKey(31) As Byte

        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey
    End Function

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        Dim chrData() As Char = strPassword.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte

        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytIV(15) As Byte

        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV
    End Function

End Class
