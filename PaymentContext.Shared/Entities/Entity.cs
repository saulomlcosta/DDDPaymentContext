using Flunt.Notifications;

namespace PaymentContext.Shared.Entities;

public class Entity : Notifiable<Notification>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
}