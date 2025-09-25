namespace Trello.WebApi.Domain.Entities.Core
{
    public abstract class BaseEntity<TKey> where TKey : struct
    {
        #region [- Props -]
        public TKey Id { get; set; }
        public DateTime CreationOn { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsArchived { get; set; }
        #endregion
    }
}
