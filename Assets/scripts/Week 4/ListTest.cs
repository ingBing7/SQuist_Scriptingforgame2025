using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<Cannonball> cannonballs = new List<Cannonball>();

    public GameObject booPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannonballs = FindObjectsByType<Cannonball>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(Cannonball ball in cannonballs)
            {
                ball.AddRandomForce();
            }
        }
    }
}
