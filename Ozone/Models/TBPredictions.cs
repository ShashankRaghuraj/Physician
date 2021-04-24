using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozone.Models
{
    public class TBPredictions
    {
        [ColumnName("model_outputs0")]
        public float[] TbType { get; set; }
    }
}
