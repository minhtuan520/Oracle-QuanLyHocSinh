using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAL
{
    public class SCORES
    {      
        public string MSHOCSINH { get; set; }
        public string NAME { get; set; }
        public Nullable<decimal> SCORE_5M { get; set; }
        public Nullable<decimal> SCORE_15M { get; set; }
        public Nullable<decimal> SCORE_45M { get; set; }
        public Nullable<decimal> SCORE_MIDYEAR { get; set; }
        public Nullable<decimal> SCORE_ENDYEAR { get; set; }
        public decimal? MEDIUMSCORE { get; set; }
    }
}
