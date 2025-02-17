using UnityEngine;

public class InstantiateScript : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BallPrefab, BallPrefabSpawn.transform.position, BallPrefabSpawn.transform.rotation);
        }
    }

}
