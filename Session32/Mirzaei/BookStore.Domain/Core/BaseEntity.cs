using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Core
{
    public abstract class BaseEntity<TKey> where TKey : struct
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
        public int AddByUserId { get; set; }
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }

    }
    public abstract class BaseEntity : BaseEntity<long>;
}
