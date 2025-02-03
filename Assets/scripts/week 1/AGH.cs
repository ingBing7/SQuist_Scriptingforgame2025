using UnityEngine;

public class AGH : MonoBehaviour
{
    int Clefable;
    float Crobat = 4.9f;
    string intro = "Sjofn is really cool and awesome!!!";
    string cool = "Other opinions irrelevant.";
    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Clefable = 36;

        Clefable = Clefable + 4 - 23 + 220 * 9;

        Debug.Log(Clefable);

        Debug.Log(Crobat);

        Crobat = Crobat + 5 * 2;

        Debug.Log(Crobat);

        Debug.Log(intro);

        Debug.Log(cool);

        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDirection * speed * Time.deltaTime;
    }
}
