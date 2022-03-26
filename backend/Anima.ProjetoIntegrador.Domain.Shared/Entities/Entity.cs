namespace Anima.ProjetoIntegrador.Domain.Shared.Entities
{
    public abstract class Entity
    {
        protected Entity() { }

        public Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
