using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //GetComponent will look for the component on the GameObject it is being called on.
    //If there is no component of the type you are trying to get, when you use the 
    //dot operator after it, it will throw a null reference exception. Get Component is super expensive, so use a local variable instead. ^^^
    //go.GetComponent<MeshRenderer>().material.color = Color.magenta; <--
    // o/\o high five


    void ColorGameObjectByName()
    {
        Debug.Log("Go is named " + go.name);
        Debug.Log("Go2 is named " + go2.name);

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>(); 

        if(go.name == "Cube")
        {
            goMeshRenderer.material.color = Color.magenta;
        }

        else if(go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan
        }

        else if(go.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black
        }

        else
        {
            goMeshRenderer.material.color = Color.yellow;
            //Change the color to yellow
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.gray;
            //Change the color to gray
        }

        else if (go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.white;
            //Change the color to white
        }

        else if (go2.name == "Cylinder")
        {
            go2MeshRenderer.material.color = Color.red;
            //Change the color to red
        }

        else
        {
            go2MeshRenderer.material.color = Color.green;
            //Change the color to orange
        }
    }

    void ColorGameObjectByTag()
    {
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "Cool Guy")
        {
            goMeshRenderer.material.color = Color.magenta;
        }

        else if (go.name == "Not Cool Guy")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan
        }

        else if (go.tag == "OKay Guy")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black
        }

        else
        {
            goMeshRenderer.material.color = Color.yellow;
            //Change the color to yellow
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Cool Guy")
        {
            go2MeshRenderer.material.color = Color.gray;
            //Change the color to gray
        }

        else if (go2.name == "Not Cool Guy")
        {
            go2MeshRenderer.material.color = Color.white;
            //Change the color to white
        }

        else if (go2.name == "OKay Guy")
        {
            go2MeshRenderer.material.color = Color.red;
            //Change the color to red
        }

        else
        {
            go2MeshRenderer.material.color = Color.green;
            //Change the color to orange
        }
    }
}
