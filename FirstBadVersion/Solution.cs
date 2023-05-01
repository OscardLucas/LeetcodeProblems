using System;
using System.Collections.Generic;
using System.Text;

namespace FirstBadVersion
{
    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return true;
        }
    }
    //35min
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            if (n == 1) return 1;

            int left = 0;
            int right = n;
            int index = (right - left) / 2;
            
            while(left < right)
            {
                if(!IsBadVersion(index))
                {
                    left = index + 1;
                    index = left + (right - left) / 2;
                }
                else
                {
                    right = index - 1;
                    index = right - (right - left) / 2;
                }

                
            }

            if (IsBadVersion(left))
                return left;
            else
            {
                return left + 1;
            }

            //search for a bad one

            //1 2 3 4 5      4

        }
    }
}
