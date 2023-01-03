using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    private float flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 517) flag = -1;
        else if (transform.position.x > 530) flag = 1;
        transform.position += new Vector3(-2,0,0)*flag * Time.deltaTime;
    }

    //void OnCollisionStay(Collision other)
    //{
    //    if (other.gameObject.name == "vBasicController_VBOT2.0_Custom")
    //    {
    //        var position = other.gameObject.transform.position;
    //        Debug.Log("Boat: x = " + transform.position.x + ",y = " + transform.position.y + ",z = " + transform.position.z);
    //        other.gameObject.transform.position = new Vector3(transform.position.x, position.y, position.z);
    //        Debug.Log("Person: x = " + position.x + ",y = " + position.y + ",z = " + position.z);
    //    }
    //}
}
