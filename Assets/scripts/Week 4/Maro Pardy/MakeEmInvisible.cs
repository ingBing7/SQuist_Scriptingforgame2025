using UnityEngine;

public class MakeEmInvisible : MonoBehaviour
{
    public float timer = 30f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomTImer();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0f)
        {
            InvisibilityScript();
            RandomTImer();
        }
    }

    void InvisibilityScript()
    {
        if(this.gameObject.GetComponent<MeshRenderer>().enabled == true)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        else
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        
    }

    void RandomTImer()
    {
        timer = Random.Range(0f, 10f);
    }
}
