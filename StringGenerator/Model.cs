using System;

namespace StringGenerator
{

    public class Model
    {
        public void IntegerCheck(string text)
        {
            if(!(text <= 0) || !(text >= 0))
            {
                View.IfNotInteger();
            }
        }
    }
}