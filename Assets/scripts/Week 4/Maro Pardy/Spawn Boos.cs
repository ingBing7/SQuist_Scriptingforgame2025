using UnityEngine;

public class SpawnBoos : MonoBehaviour
{
    public GameObject booPrefab;

    public Transform booPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(booPrefab, booPosition.transform.position, booPosition.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
