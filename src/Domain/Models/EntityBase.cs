
namespace POS.Domain.Models
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
        public string UserModifyId { get; set; } = string.Empty;
    }
}
