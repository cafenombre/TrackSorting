using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackSorting.Entities
{
    class Track
    {
        #region properties
        
        public string name { get; set; }
        
        // More properties like date, album, artist will be added here

        #endregion

        #region constructors

        /// <summary>Basic constructor only with the track name.</summary>
        /// <param name="trackname">Track name that should be gathered from the Track_List.txt</param>
        public Track (string trackname)
        {
            this.name = trackname;
        }

        /// <summary>Empty constructor if needed</summary>
        public Track()
        {
            this.name = "";
        }
        #endregion

        #region methods
        #endregion

    }
}
