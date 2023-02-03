using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenController2 : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (player.transform.position.x < 525.0f && player.transform.position.x > 316.54f && player.transform.position.z > - 1259.85f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
            transform.position += transform.forward * 2.5f * Time.deltaTime;
            //animator.SetBool("walking", true);
        }
        else
        {

            Vector3 hardFix = new Vector3(363.4f, 1.000001f, -1246.57f);
            Quaternion targetRotation = Quaternion.LookRotation(hardFix - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
            transform.position += transform.forward * 6.1f * Time.deltaTime;
            //if(transform.position == hardFix)
            //{
            //    animator.SetBool("walking", false);
            //}
            //else
            //{
            //    animator.SetBool("walking", true);
            //}
        }

        //if(distance < 15)
        //{
        //    animator.SetBool("attack",true);
        //}
        //else
        //{
        //    animator.SetBool("false", true);
        //}

    }
}
