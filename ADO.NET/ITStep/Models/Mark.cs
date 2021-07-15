using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Models
{
	public class Mark
	{
        public int Id { get; set; }
        public int? StudentFK { get; set; }
        public int? SubjectFK { get; set; }
        public int Score { get; set; }
    }
}
