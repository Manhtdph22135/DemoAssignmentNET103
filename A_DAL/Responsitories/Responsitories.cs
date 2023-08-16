using A_DAL.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Responsitories
{
    public class Responsitories
    {
        private AssetContext assetContext;

        public Responsitories()
        {
            assetContext = new AssetContext();
        }
        public List<TaiSan> GetAll()
        {
            return assetContext.TaiSans.ToList();
        }
    } 
}
