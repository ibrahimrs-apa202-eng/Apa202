class Program
{
    static void Main(string[] args)
    {
        LoginSystem system = new LoginSystem();

        while (true)
        {
            try
            {
                Console.WriteLine("\n--- GİRİŞ SİSTEMİ ---");
                Console.Write("Username: ");
                string userInp = Console.ReadLine();

                Console.Write("Password: ");
                string passInp = Console.ReadLine();

                if (system.Login(userInp, passInp))
                {
                    break; // Uğurlu giriş
                }
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                system.ShowAllUsers();
            }
            catch (IncorrectPasswordException ex)
            {
                Console.WriteLine($"WARNING: {ex.Message}");
            }
            catch (AccountLockedException ex)
            {
                Console.WriteLine($"CRITICAL: {ex.Message}");
                Console.WriteLine("Zəhmət olmasa adminlə əlaqə saxlayın.");
                break; // Bloklandıqda proqram dayanır
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UNEXPECTED ERROR: {ex.Message}");
            }
        }

        Console.WriteLine("\nProqram başa çatdı. Çıxmaq üçün bir tuşa basın...");
        Console.ReadKey();
    }
}
