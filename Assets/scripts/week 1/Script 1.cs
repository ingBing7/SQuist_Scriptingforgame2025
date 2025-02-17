using UnityEngine;

public class Script1 : MonoBehaviour
{
    int Clefable;
    int Crobat;
    int Gible;
    int Total;
    int Arceus;
    int Articuno;

    // I wanted to do more equations since I'm turning in this assignment late, haha. 
    // Idk if you read the notes but, hi! o/
    // I'm no longer sick!! 

    void Start()
    {
        Clefable = 41;
        Crobat = 169;
        Gible = 443;

        Debug.Log(Clefable);
        Debug.Log(Crobat);
        Debug.Log(Gible);

        Total = Crobat + Clefable * Gible;

        Debug.Log(Total);

        Arceus = Gible + 300 - Clefable / Crobat;

        Debug.Log(Arceus);

        Articuno = Total + Clefable / Gible - Clefable + Arceus + Crobat;

        Debug.Log(Articuno);

    }

    // The integers Clefable, Crobat, and Gible are their respective numbers in the pokedex. This isn't relevant, I just wanted to share.

    // Update is called once per frame
    void Update()
    {
        
    }
}
