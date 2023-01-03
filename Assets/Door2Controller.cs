using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Controller : MonoBehaviour
{
    public Animator TrapDoorAnim; //Animator for the trap door;
    public static Door2Controller Instance;
    bool isClose = true;
    // Use this for initialization
    void Awake()
    {
        Instance = this;
        //get the Animator component from the trap;
        // TrapDoorAnim = GetComponent<Animator>();
        //start opening and closing the trap for demo purposes;
    }
    void Update()
    {
        Instance = this;
        TrapDoorAnim = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        isClose = false;
        TrapDoorAnim.SetTrigger("open");
    }
    public void CloseDoor()
    {
        Debug.Log(isClose);
        if (isClose == false)
        {
            TrapDoorAnim.SetTrigger("close");
            isClose = true;
        }
    }
}
