using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_C__Program
{
    public class ClusmyFactorial
    {
        public int Clusmyfactorialnumber;
        public ClusmyFactorial(int n) {
            Clusmyfactorialnumber = Clusmy(n);
        }
        public int Clusmy(int clusmyfactorialnumber)
        {
            int result = 0;

            for(int i = clusmyfactorialnumber; i > 0; i-=4)
            {
                int block = i;
                if (block - 1 > 0) block *= (i - 1);
                if (block - 2 > 0) block /= (i - 2);

                if (result == 0)
                    result = block;
                else
                    result -= block;

                if (block - 3 > 0)
                    result += (i - 3);
            }

            return result;
        }
    }
}
