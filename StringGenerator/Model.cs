using System;

namespace StringGenerator
{

    public class Model
    {
        public void IntegerCheck(string  text)
        {
            if(!(int.Parse(text) <= 0) || !(int.Parse(text) >= 0))
            {
                View.IfNotInteger();
            }
        }
    }
}