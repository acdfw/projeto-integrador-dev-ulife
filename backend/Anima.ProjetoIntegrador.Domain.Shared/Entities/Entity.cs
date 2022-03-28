namespace Anima.ProjetoIntegrador.Domain.Shared.Entities
{
    public abstract class Entity
    {
        protected Entity() {}

        protected Entity(Guid id) => Id = id;

        public Guid Id { get; private set; }
    }
}
