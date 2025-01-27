 using UnityEngine;

public class datatypepractice : MonoBehaviour
{
    int santaClaus;

    float goomba = 4.8f;

    char Clefable = 'F';

    string Crobat = "Crobat number one";

    public string chestName;

     

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;

        santaClaus = santaClaus + 5 + 6 - (2 / 6);

        Debug.Log(santaClaus);

        Debug.Log(goomba);

        goomba = goomba - 2;

        Debug.Log(goomba);

        Debug.Log(Clefable);

        Debug.Log(Crobat);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
