using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guía_N_5___PED
{
    class Parentesis
    {
        char[] parentesisini = { '(','[','{'};
        char[] parentesisfin = { ')', ']','}' };
        
        public bool inicio(char a)
        {
            
            for(int i=0;i<parentesisini.Length;i++)
            {
                if (parentesisini[i] == a)
                    return true;
            }
            return false;
        }

        public char Obtener(char a)
        {
            for(int i=0;i<parentesisini.Length;i++)
            {
                if(parentesisini[i]==a)
                {
                    return parentesisfin[i];
                }

            }
            for(int i=0;i<parentesisfin.Length;i++)
            {
                if(parentesisfin[i]==a)
                {
                    return parentesisini[i];
                }
            }
            return ' ';
        }
    }
    class Palindromo
    {
        Stack<char> palindromo = new Stack<char>();
        public bool Verificar(string b)
        {
            string d, f=null;
            char g;
            if(b.Contains(" "))
            {
                b = b.Replace(" ", "");
            }
            d = b;
            foreach(char a in b)
            {
                if(char.IsUpper(a))
                {
                    g = char.ToLower(a);
                }
                else
                {
                    g = char.ToLower(a);
                }
                f += g;
            }
            char[] c = f.ToCharArray();
            for(int i=0;i<f.Length;i++)
            {
                palindromo.Push(c[i]);
            }
            for (int i = 0; i < f.Length; i++)
            {
                if(palindromo.Peek()==c[i])
                palindromo.Pop();
            }
            if(palindromo.Count==0)
            {
                return true;
            }
            return false;
        }

    }
}
