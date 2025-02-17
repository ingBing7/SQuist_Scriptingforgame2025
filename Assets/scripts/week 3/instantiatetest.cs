using UnityEngine;

public class instantiatetest : MonoBehaviour
{
    public GameObject CannonBallPrefab;

    public GameObject CannonBallSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject go = Instantiate(CannonBallPrefab, CannonBallSpawnPosition.transform.position, CannonBallPrefab.transform.rotation);

        go.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(CannonBallPrefab, CannonBallSpawnPosition.transform.position, CannonBallPrefab.transform.rotation);
        }
        
    }
}
