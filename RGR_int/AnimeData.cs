using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace RGR_int
{
    class AnimeData
    {
        public AnimeData(string russian, Image image)
        {
            Russian = russian;
            Image = image.Preview;
        }

        public string Russian { get; set; }
        public string Image { get; set; }
    }



}
