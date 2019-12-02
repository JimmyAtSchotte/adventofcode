using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace adventofcode.Services
{
    public class IntcodeService : IIntcodeService
    {
        public string FindNounAndVerb(int expectedResult, int[] codes)
        {
            for (int noun = 0; noun <= 99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    for (int i = 0; i < codes.Length; i += 4)
                    {
                        if (codes[i] == 99 || i + 4 > codes.Length)
                            continue;

                        var processCodes = new int[codes.Length];
                        codes.CopyTo(processCodes, 0);

                        processCodes[i + 1] = noun;
                        processCodes[i + 2] = verb;

                        try
                        {
                            var result = ProcessCodeList(processCodes);

                            if (result[0] == expectedResult)
                                return $"{noun.ToString("00")}{verb.ToString("00")}";
                        }
                        catch (Exception)
                        {

                        }                        
                    }
                }
            }

            return string.Empty;
        }

        public int[] ProcessCodeList(int[] codes)
        {
            for (int i = 0; i < codes.Length; i += 4)
            {
                switch (codes[i])
                {
                    case 1:
                        codes[codes[i + 3]] = codes[codes[i + 1]] + codes[codes[i + 2]];
                        break;
                    case 2:
                        codes[codes[i + 3]] = codes[codes[i + 1]] * codes[codes[i + 2]];
                        break;
                    case 99:
                        return codes;
                    default:
                        throw new ArgumentException(message: "invalid opcode value");
                }
            }
           

            return codes;
        }
    }
}
