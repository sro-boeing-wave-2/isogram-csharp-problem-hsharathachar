using System;

namespace isogram_csharp_problem
{
    public class Class1
    {

        public bool IsIsogramOrNot(string input)
        {
        int k = 0;
            
        for (int i=0; i<input.Length; i++)
            {
            if (((int)input[i] > 64 && (int)input[i] < 91) || ((int)input[i] > 96 && (int)input[i] < 123))
                {
                for (int j=i+1; j<input.Length; j++)
                    {
                    if (input[i] == input[j])
                        {
                        k = 1;
                        break;
                        }
                    }
                for (int j=0; j<i; j++)
                    {
                    if (input[i] == input[j])
                        {
                        k = 1;
                        break;
                        }
                    }
                if (k == 1)
                    {
                    break;
                    }
                }
            }
        if (k == 1)
            {
            return false;   //returns bool value false
            }
        else
            {
            return true;    //returns bool value true
            }
        }
    }
}
