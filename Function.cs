using System.Collections.Generic;
using System;

namespace Text_Encryptor
{
    public class Function
    {
        protected List<Term> terms = new List<Term>();

        public int Call(int x)
        {
            double result = 0;
            foreach(Term term in terms)
            {
                result += term.factor * Math.Pow(x, term.power);
            }
            return (int)result;
        }

    }

    public class BasicFunction : Function
    {
        public BasicFunction(int factor, int fixTerm)
        {
            terms.Add(new Term(factor,1));
            terms.Add(new Term(fixTerm,0));
        }

        public double ReverseCall(int x)
        {
            double result = (double)(x - terms[1].factor) / (double)terms[0].factor;
            return result;
        }
    }

    public class Term
    {
        public int factor;
        public int power;

        public Term(int factor, int power)
        {
            this.factor = factor;
            this.power = power < 0 ? 0 : power;
        }
    }
}
