using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject canonballPrefab;
    public Transform canonballspawnlocation;
    public float forcePower = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireCanon();
        }
        */
    }

    public void FireCanon()
    {
        GameObject go = Instantiate(canonballPrefab, canonballspawnlocation.position, canonballspawnlocation.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * forcePower);
    }
}
