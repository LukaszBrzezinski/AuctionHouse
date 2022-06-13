namespace AuctionHouse.API.Services
{
    public interface IPassword
    {
        string IsCorrectPassword();
        bool IsExistCapitalLetter();
        bool IsPasswordTooShort();
    }
}