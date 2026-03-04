using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            #region Q3
            //A shallow copy creates a new object but copies the references of nested objects, so both objects share the same referenced data.
            //A deep copy creates a new object and also copies all nested objects, making the copy completely independent.

            //Shallow copy is used when sharing references is acceptable and copying needs to be fast.Deep copy is used when the copied object must be completely independent.

            //The risk of shallow copy is that changes to reference-type fields in one object will affect the other object since they share the same referenced objects.
            #endregion

            #region Q4
            //Dev - Testing
            //QA - Testing

            //MemberwiseClone() performs a shallow copy, meaning value types are copied but reference types share the same object.
            //Title changes only for e2, but Dept is shared between e1 and e2, so changing Dept.Name affects both objects.
            #endregion
                #endregion
        }
    }
}
