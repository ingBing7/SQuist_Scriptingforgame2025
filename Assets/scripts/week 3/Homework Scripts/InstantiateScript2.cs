using UnityEngine;

public class InstantiateScript2 : MonoBehaviour
{
    public GameObject BallPrefab;

    public GameObject BallPrefabSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PrefabSpawner")
        {
            Instantiate(BallPrefab, BallPrefabSpawn.transform.position, BallPrefabSpawn.transform.rotation);
        }
    }
}
