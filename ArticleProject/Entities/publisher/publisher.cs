using ArticleProject.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace ArticleProject.Entities.publisher
{
    public class publisher : BaseEntity
    {
        #region MyProperty

        [Required]
        [MaxLength(255)]
        public string FName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LName { get; set; }

        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(10)]
        public string Ncode { get; set; }

        [Required]
        public bool IsActive { get; set; }
        #endregion

        #region MyRegion
        public ICollection<Articlee> articlees { get; set; }
        #endregion
    }
}
