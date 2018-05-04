using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAL
{
    public class ViewStudentScores
    {
        public string SubjectName { get; set; }
        public decimal? SCORE_5M { get; set; }
        public decimal? SCORE_15M { get; set; }
        public decimal? SCORE_45M { get; set; }
        public decimal? SCORE_MIDYEAR { get; set; }
        public decimal? SCORE_ENDYEAR { get; set; }
        public decimal? MEDIUMSCORE { get; set; }
    }
}
