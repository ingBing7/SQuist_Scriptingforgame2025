using UnityEngine;

public class Lightchanger : MonoBehaviour
{
    public Light lightwewanttochange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ChangeLightColor(Color.yellow);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            ChangeLightColor(Color.blue);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            ChangeLightColor(Color.green);
        }
    }

    public void ChangeLightColor(Color Clefable)
    {
        lightwewanttochange.color = Clefable;
    }
}