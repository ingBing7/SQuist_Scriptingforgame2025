using UnityEngine;

public class testscript : MonoBehaviour
{
    public GameObject sphere;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.GetComponent<MeshRenderer>().enabled == false)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
