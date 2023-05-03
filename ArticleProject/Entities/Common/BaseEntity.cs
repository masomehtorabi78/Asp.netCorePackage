using System.ComponentModel.DataAnnotations;

namespace ArticleProject.Entities.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
