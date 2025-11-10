using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

/* Fix me */
//List<dynamic> listOfStrings = new List<dynamic> { "13", "Candy", "Mike Myers", true, #FF5F1F, 1978 };


Debug.Assert(NextOnAThursday() == 2031);

int NextOnAThursday()
{
    int year = 2025;
    int day = 4;
    do
    {
        year += 1;
        day += 365;
        if (year % 4 == 0)//is leap year
        {
            day += 1;
        }
    } while ((day % 7) != 4);
    return year;
}
int NextOnAThursday2()
{
    int year = 2025;
    int day; 
    do {
        year += 1;
        day = (int) (new DateTime(year, 11, 06).DayOfWeek);
    } while ((day%7) != 4);
    return year;
}

List<int> pileSizes = new List<int> { 4, 9, 11, 17 };
int numHours = 8;

int EatingSweets(List<int> piles, int numHours)
{
    int sph = piles.Count();
    bool Possible(int sph, List<int> piles, int hsleep)
    {
        int h = 0;
        foreach (int p in piles){ h += (int)(p / sph) + 1; }
        return (hsleep <= h);
    } 
    
    while (!Possible(sph,piles,numHours))
    {
        sph += 1;
    }
    return sph;
}


Debug.Assert(EatingSweets(pileSizes, numHours) == 6);

int CuttingChocolate(int cuts) {
    if (cuts%2==0){return (int)(cuts / 2)*(cuts / 2) ;}
    return ((int)cuts / 2)*((int)cuts / 2 +1) ;
}

Debug.Assert(CuttingChocolate(5) == 6);
Debug.Assert(CuttingChocolate(6) == 9);
Debug.Assert(CuttingChocolate(7) == 12);
Debug.Assert(CuttingChocolate(8) == 16);

// Note the exclamation marks showing not, so False 
Debug.Assert(!ValidatePassword("ABCdef")); // too short
Debug.Assert(!ValidatePassword("ABCABC12!")); // duplicates, doesn't divide by 11
Debug.Assert(!ValidatePassword("ABCabcde!")); // no digit 
Debug.Assert(!ValidatePassword("ABCdef12!")); // doesn't divide by 11 
Debug.Assert(ValidatePassword("ABCdef12&")); // should succeed 


bool ValidatePassword(string candidate)
{
    return false;
}