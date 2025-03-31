using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class WhileLoopdown : MonoBehaviour
{
    public float speed = 3f;
    Coroutine co;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*while(this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }*/

        //StartCoroutine(MoveRightAndChangeColor());

        //dont be a doofus put the parenthasees after, ingrid.

        co = StartCoroutine(MoveRightAndChangeColor());
    }

    // Update is called once per frame
    void Update()
    {
            /*
        while(this.transform.position.y < 10)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
            */

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
        }
    }

    IEnumerator MoveRightAndChangeColor()
    {
        /*Debug.Log("frame 1 runs");
        yield return null; //yield return null will pause the code until the next frame.
        Debug.Log("frame 2 runs");
        yield return new WaitForSeconds(2f); //This will wait 2 seconds before continuing code. Good for timers!!!
        //wait a specific amount of time to continue.
        Debug.Log("waited 2 seconds before posting this");*/

        while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);
        this.GetComponent<MeshRenderer>().material.color = Color.blue;
        yield return new WaitForSeconds(2f);


        //woaj
        //im gonna fall asleep im so so tired  
        //this fucking box is blue and im about to fall asleep witchery

        while (this.transform.position.x > -8f)
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);
        this.GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(2f);
    }

    // Coroutines let you sequence things in a very nice way. :)

}
