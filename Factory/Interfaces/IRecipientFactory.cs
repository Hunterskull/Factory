using Factory.Models;

namespace Factory.Interfaces
{
    public interface IRecipientFactory
    {
        public Recipient CreateRecipient(RecipientType type, string address);
    }
}