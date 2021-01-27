using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1
{
    public class Album
    {
        public string AlbumName { get; set; }
        public int YearsOfRelease { get; set; }
        public int Sales { get; set; }

        public Album(string _albumName, int _yearsOfRelease, int _sales)
        {
            AlbumName = _albumName;
            YearsOfRelease = _yearsOfRelease;
            Sales = _sales;
        }

        public Album()
        {

        }

        public override string ToString()
        {
            return string.Format($"{AlbumName}- Released in {YearsOfRelease} sales of {Sales}");


        }
    }
}

