using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            #region Q1
            //We use interfaces to achieve loose coupling, 
            //improve testability, support dependency injection,
            //and follow SOLID principles.
            #endregion

            #region Q2
            //a) The problem is that both interfaces contain a method called Greet(),
            //so the class provides one implementation that is used for both interfaces.

            //b) This can be fixed using Explicit Interface Implementation,
            //allowing each interface method to have a different implementation.

            //c)No, translator.Greet() cannot be called directly.
            //The method must be called through the interface reference like((IEnglishSpeaker) translator).Greet().
            #endregion

            #endregion
        }
    }
}
