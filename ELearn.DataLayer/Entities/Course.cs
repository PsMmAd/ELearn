using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.DataLayer.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseTitel { get; set; }
        public string CourseThumbnail { get; set; }
        public bool IsFree { get; set; }
        public double? Price { get; set; }
        public int CourseDescription { get; set; }
        public int? SellCount { get; set; }
        public int Views { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        #region Relations
        public CourseGroup CourseGroup { get; set; }
        public ICollection<CourseSeason> CourseSeasons { get; set; }
        #endregion


    }
}
