/**10.Write a C# Sharp program to compares four sets of words by using each member of the string comparison enumeration.**/

using System;
using System.Globalization;
using System.Threading;

namespace july
{
    class june30_10
    {
        static void Main(string[] args)
        {
            String[] cultureNames = { "en-AU", "sv-SE" };
            String[] strs1 = { "case",  "encyclopedia",  
                               "encyclopedia", "Archeology" };
            String[] strs2 = { "Case", "encyclopedia", 
                               "encyclopedia" , "ARCHEOLOGY" };
            StringComparison[] comparisons = (StringComparison[]) Enum.GetValues(typeof(StringComparison));
            
            foreach (var cultureName in cultureNames) 
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++) 
                {
                    foreach (var comparison in comparisons)
                    Console.WriteLine("   {0} = {1} ({2}): {3}", strs1[ctr],
                                      strs2[ctr], comparison, 
                                      String.Equals(strs1[ctr], strs2[ctr], comparison));
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

    }
    
}

/**
Output :
-------------
Current Culture: en-AU
   case = Case (CurrentCulture): False
   case = Case (CurrentCultureIgnoreCase): True
   case = Case (InvariantCulture): False
   case = Case (InvariantCultureIgnoreCase): True
   case = Case (Ordinal): False
   case = Case (OrdinalIgnoreCase): True

   encyclopedia = encyclopedia (CurrentCulture): True
   encyclopedia = encyclopedia (CurrentCultureIgnoreCase): True
   encyclopedia = encyclopedia (InvariantCulture): True
   encyclopedia = encyclopedia (InvariantCultureIgnoreCase): True
   encyclopedia = encyclopedia (Ordinal): True
   encyclopedia = encyclopedia (OrdinalIgnoreCase): True

   encyclopedia = encyclopedia (CurrentCulture): True
   encyclopedia = encyclopedia (CurrentCultureIgnoreCase): True
   encyclopedia = encyclopedia (InvariantCulture): True
   encyclopedia = encyclopedia (InvariantCultureIgnoreCase): True
   encyclopedia = encyclopedia (Ordinal): True
   encyclopedia = encyclopedia (OrdinalIgnoreCase): True

   Archeology = ARCHEOLOGY (CurrentCulture): False
   Archeology = ARCHEOLOGY (CurrentCultureIgnoreCase): True
   Archeology = ARCHEOLOGY (InvariantCulture): False
   Archeology = ARCHEOLOGY (InvariantCultureIgnoreCase): True
   Archeology = ARCHEOLOGY (Ordinal): False
   Archeology = ARCHEOLOGY (OrdinalIgnoreCase): True


Current Culture: sv-SE
   case = Case (CurrentCulture): False
   case = Case (CurrentCultureIgnoreCase): True
   case = Case (InvariantCulture): False
   case = Case (InvariantCultureIgnoreCase): True
   case = Case (Ordinal): False
   case = Case (OrdinalIgnoreCase): True

   encyclopedia = encyclopedia (CurrentCulture): True
   encyclopedia = encyclopedia (CurrentCultureIgnoreCase): True
   encyclopedia = encyclopedia (InvariantCulture): True
   encyclopedia = encyclopedia (InvariantCultureIgnoreCase): True
   encyclopedia = encyclopedia (Ordinal): True
   encyclopedia = encyclopedia (OrdinalIgnoreCase): True

   encyclopedia = encyclopedia (CurrentCulture): True
   encyclopedia = encyclopedia (CurrentCultureIgnoreCase): True
   encyclopedia = encyclopedia (InvariantCulture): True
   encyclopedia = encyclopedia (InvariantCultureIgnoreCase): True
   encyclopedia = encyclopedia (Ordinal): True
   encyclopedia = encyclopedia (OrdinalIgnoreCase): True

   Archeology = ARCHEOLOGY (CurrentCulture): False
   Archeology = ARCHEOLOGY (CurrentCultureIgnoreCase): True
   Archeology = ARCHEOLOGY (InvariantCulture): False
   Archeology = ARCHEOLOGY (InvariantCultureIgnoreCase): True
   Archeology = ARCHEOLOGY (Ordinal): False
   Archeology = ARCHEOLOGY (OrdinalIgnoreCase): True
   **/
