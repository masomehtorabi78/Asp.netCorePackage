using ArticleProject.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace ArticleProject.Entities.publisher
{
    public class Articlee : BaseEntity
    {
        #region MyProperty
        public int publisherId { get; set; }
        [Required]
        [MaxLength(300)]

        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string ShortDescription { get; set; }

        [Required]
        public string ProductDescription { get; set; }
        public int Inventory { get; set; }

        [MaxLength(1000)]
        public string Tags { get; set; }

        [Required]
        [MaxLength(255)]
        public string Image { get; set; }

        public int Price { get; set; }
        [Required]
        public bool IsActive { get; set; }
        #endregion


        #region Relation
        public publisher publisher { get; set; }
        #endregion
    }
}
