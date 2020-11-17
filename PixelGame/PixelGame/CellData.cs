using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelGame
{
    public class CellData
    {
        public int cellid;
        /// <summary>
        /// List of the IDs of the four neighboring cells, in the order of NESW. Value of -1 means no cell in that position.
        /// </summary>
        public List<int> neighborIDList { get; private set; }

        public CellData()
        {
            cellid = 0;
            neighborIDList = new List<int>() { 1, 2, 3, 4 };
        }
        public CellData(int CellID, IEnumerable<int> neighborList)
        {
            cellid = CellID;
            neighborIDList = neighborList.ToList();
        }
    }
}
