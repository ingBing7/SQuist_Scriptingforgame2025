using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public Dirtbossing dirtbosscontroller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dirtbosscontroller.scaleIncrease = 5f;
        dirtbosscontroller.RotateDirtBoss();
        dirtbosscontroller.RotateDirtBoss();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
