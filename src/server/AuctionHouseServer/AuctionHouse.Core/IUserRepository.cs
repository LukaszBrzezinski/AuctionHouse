namespace AuctionHouse.Core
{
    public interface IUserRepository
    {
        bool UserExists(string email);
        void AddUser(User user);
    }
}
