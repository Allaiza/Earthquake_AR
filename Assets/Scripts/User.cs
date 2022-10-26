using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private GameObject userObj = null;

    // Start is called before the first frame update
    void Start()
    {
        if (userObj == null)
            userObj = GameObject.Find("User");
    }

    public Vector3 getPosition()
    {
        return userObj.gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("User Position: X = " + userObj.transform.position.x + " --- Y = "
            + userObj.transform.position.y + " --- Z = " + userObj.transform.position.z);
    }
}
