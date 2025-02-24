using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Canon> canons = new List<Canon>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canons = FindObjectsByType<Canon>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Canon c in canons)
        {
            c.FireCanon();
        }
    }
}
