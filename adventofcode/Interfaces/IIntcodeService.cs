using System;
using System.Collections.Generic;
using System.Text;

namespace adventofcode.Interfaces
{
    public interface IIntcodeService
    {
        int[] ProcessCodeList(int[] codes);

        string FindNounAndVerb(int expectedResult, int[] codes);
    }
}
