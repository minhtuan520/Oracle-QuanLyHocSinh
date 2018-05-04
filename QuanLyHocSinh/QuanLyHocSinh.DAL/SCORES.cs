using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAL
{
    public class SCORES
    {      
        public string MSHOCSINH { get; set; }
        public string NAME { get; set; }
        [Range(typeof(Decimal), "0", "10", ErrorMessage = "{0} must be a decimal/number between {1} and {2}")]
        public Nullable<decimal> SCORE_5M { get; set; }
        [Range(typeof(Decimal), "0", "10", ErrorMessage = "{0} must be a decimal/number between {1} and {2}")]
        public Nullable<decimal> SCORE_15M { get; set; }
        [Range(typeof(Decimal), "0", "10", ErrorMessage = "{0} must be a decimal/number between {1} and {2}")]
        public Nullable<decimal> SCORE_45M { get; set; }
        [Range(typeof(Decimal), "0", "10", ErrorMessage = "{0} must be a decimal/number between {1} and {2}")]
        public Nullable<decimal> SCORE_MIDYEAR { get; set; }
        [Range(typeof(Decimal), "0", "10", ErrorMessage = "{0} must be a decimal/number between {1} and {2}")]
        public Nullable<decimal> SCORE_ENDYEAR { get; set; }
        [Range(typeof(Decimal), "0", "10", ErrorMessage = "{0} must be a decimal/number between {1} and {2}")]
        public decimal? MEDIUMSCORE { get; set; }
    }
}
