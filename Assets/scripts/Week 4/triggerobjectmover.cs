using UnityEngine;

public class triggerobjectmover : MonoBehaviour
{
    public GameObject wall;

    public bool hashitTrigger = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hashitTrigger == true)
        {
            wall.transform.position += Vector3.right * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cannonball")
        {
            hashitTrigger = true;
        }
    }
}
