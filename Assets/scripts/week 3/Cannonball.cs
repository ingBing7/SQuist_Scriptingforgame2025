using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision otherObject)
    {
        Debug.Log(otherObject.gameObject.name);

        if(otherObject.gameObject.tag == "Floor")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            otherObject.gameObject.GetComponent<FloorScript>().SayHello();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.tag == "Up Force")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
        }

        else if(other.gameObject.tag == "Down Force")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 500f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
