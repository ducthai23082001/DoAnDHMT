using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator TrapDoorAnim; //Animator for the trap door;
    public static DoorController Instance;
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
        Debug.Log(TrapDoorAnim);
        TrapDoorAnim.SetTrigger("open");
    }
}
