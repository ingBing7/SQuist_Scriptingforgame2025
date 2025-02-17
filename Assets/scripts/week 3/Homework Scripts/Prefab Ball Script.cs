using UnityEngine;

public class PrefabBallScript : MonoBehaviour
{

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
        if(other.gameObject.tag == "Up Force")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1500f);
        }

        else if (other.gameObject.tag == "LeftForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * 750);
        }

        else if (other.gameObject.tag == "RightForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 2000f);
        }

        else if (other.gameObject.tag == "ColorChanger1")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        else if (other.gameObject.tag == "ColorChanger2")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

        else if (other.gameObject.tag == "ColorChanger3")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }

        else if (other.gameObject.tag == "ColorChanger4")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
        }

    }

    void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "ColorChanger5")
        {
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
        }

        if (otherObject.gameObject.tag == "ColorChanger6")
        {
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
        }



    }
}
