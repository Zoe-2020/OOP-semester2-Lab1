using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1
{
    public abstract class Band:IComparable
    {
        public string BandName { get; set; }
        public int year { get; set; }

        public string Members { get; set; }

        public List<Album> AlbumList { get; set; }

        public Band(string _bandName, int _year, string _memebers)
        {
            BandName = _bandName;
            year = _year;
            Members = _memebers;

            AlbumList = new List<Album>();
        }



        public Band() : this("unknown", 1960, "unknown") { }
       
        public override string ToString()
        {
            return BandName;
        }

        public int CompareTo(object obj)
        {
            Band otherband = obj as Band;
            return this.BandName.CompareTo(otherband.BandName);
        }
            

    }

    public class RocBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Rock band";
        }
    }
    public class PopBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Pop band";
        }
    }

    public class IndieBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Indie band";
        }
    }



}