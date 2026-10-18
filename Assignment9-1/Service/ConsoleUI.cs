using Assignment9_1.DataTransferObjects;

namespace Assignment9_1.Service;

/// <summary>
/// Handles console input and output for the staff login.
/// </summary>
public class ConsoleUI
{
    private readonly AuthService _authService;

    public ConsoleUI(AuthService authService)
    {
        _authService = authService;
    }

    public void RunLogin()
    {
        // TODO: Ask for the username and password, then call Authenticate.
        Console.WriteLine("Username: ");
        string username = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Password: ");
        string password = Console.ReadLine() ?? string.Empty;
        try
        {
            SessionTokenDto sessionToken = _authService.Authenticate(username, password);
            DisplayLoginSuccess(sessionToken);
        }
        catch
        {
            DisplayLoginFailed();
        }
    }

    private static void DisplayLoginSuccess(SessionTokenDto sessionToken)
    {
        // TODO: Display the username, display name, and token.
        Console.WriteLine($"Username: {sessionToken.Username}");
        Console.WriteLine($"Display Name: {sessionToken.DisplayName}");
        Console.WriteLine($"Token: {sessionToken.Token}");
    }

    private static void DisplayLoginFailed()
    {
        // TODO: Display the generic login-failure message.
        Console.WriteLine("Login failed. Check your username and password.");
    }
}
