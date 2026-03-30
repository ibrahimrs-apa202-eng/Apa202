using System;

public class InvalidUsernameException : Exception
{
    public InvalidUsernameException() : base("Username boş ola bilməz və ən azı 3 simvol olmalıdır.") { }
    public InvalidUsernameException(string message) : base(message) { }
}

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException() : base("Şifrə boş ola bilməz və ən azı 6 simvol olmalıdır.") { }
    public InvalidPasswordException(string message) : base(message) { }
}

public class UserNotFoundException : Exception
{
    public UserNotFoundException() : base("İstifadəçi tapılmadı.") { }
    public UserNotFoundException(string username) : base($"'{username}' adlı istifadəçi sistemdə mövcud deyil.") { }
}

public class IncorrectPasswordException : Exception
{
    public int AttemptsLeft { get; }
    public IncorrectPasswordException(int attemptsLeft)
        : base($"Şifrə yanlışdır. Qalan cəhd sayı: {attemptsLeft}")
    {
        AttemptsLeft = attemptsLeft;
    }
}

public class AccountLockedException : Exception
{
    public AccountLockedException() : base("Hesabınız 3 uğursuz cəhdə görə bloklanıb!") { }
}
