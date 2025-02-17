using UnityEngine;

public class InstantiateScript2 : MonoBehaviour
{
    public GameObject BallPrefab2;

    public Transform BallPrefabSpawn;

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
       if(other.gameObject.tag == "PrefabSphere")
        {
            Instantiate(BallPrefab2, BallPrefabSpawn.position, BallPrefabSpawn.rotation);
        }
    }
}
