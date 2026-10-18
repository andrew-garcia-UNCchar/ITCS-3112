using Assignment9_1.DataTransferObjects;
using Assignment9_1.Domain;
using Assignment9_1.Exceptions;

namespace Assignment9_1.Service;

/// <summary>
/// Coordinates staff lookup, credential checking, and session-token creation.
/// </summary>
public class AuthService
{
    private readonly StaffRepository _staffRepository;

    public AuthService(StaffRepository staffRepository)
    {
        _staffRepository = staffRepository;
    }

    public SessionTokenDto Authenticate(string username, string password)
    {
        // TODO: Find the account, check it, and return a session-token DTO.
        StaffAccount? account = _staffRepository.FindByUsername(username);
        if (account is null) {
            throw new InvalidCredentialException();
        }
        VerifyCredentialsAndPermissions(account, password);
        
        return CreateSessionToken(account);
    }

    private static void VerifyCredentialsAndPermissions(StaffAccount account, string password)
    {
        // TODO: Compare the password and check CanManageParticipation.
        if (account.Password != password || !account.CanManageParticipation)
        {
            throw new InvalidCredentialException();
        }
    }

    private static SessionTokenDto CreateSessionToken(StaffAccount account)
    {
        // TODO: Return a SessionTokenDto containing a new token, username, and display name.
        return new SessionTokenDto(Guid.NewGuid().ToString(), account.Username, account.DisplayName);
    }
}
