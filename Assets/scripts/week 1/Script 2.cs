using UnityEngine;

public class Script2 : MonoBehaviour
{
    public float Platinum = 4;
    public float Moon = 7;
    public float Scarlet = 9;
    float Total;

    // Some of my favorite Pokemon games plus Scarlet because I'm 100%'ing it. #Achiever B)
    void Start()
    {
        Total = Platinum + Moon * Scarlet;
        Debug.Log(Total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
