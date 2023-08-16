using A_DAL.A_DAL.Models;
using A_DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class TaiSanServices
    {
        private Responsitories responsitories = new Responsitories();
        private List<TaiSan> taiSans = new List<TaiSan>();
        public List<TaiSan> GetData()
        {
            return taiSans = responsitories.GetAll();
        }
    }
}
