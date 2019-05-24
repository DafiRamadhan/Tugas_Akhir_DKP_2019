using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir
{
    class Data
    {
        int Biaya;
        int Total;
        
        public void setBiaya(int var)
        {
            Biaya = var;
        }
        public int getBiaya()
        {
            return Biaya;
        }
        public void setTotal(int var)
        {
            Total = var;
        }
        public int getTotal()
        {
            return Total;
        }
    }
}
