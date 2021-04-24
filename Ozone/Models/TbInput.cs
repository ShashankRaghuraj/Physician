using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Transforms.Image;
namespace Ozone.Models
{
    public class TbInput
    {
        [ImageType(ImageSettings.imageHeight, ImageSettings.imageWidth)]
        public Bitmap Image { get; set; }
    }
}
