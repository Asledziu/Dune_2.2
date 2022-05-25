using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Trigger_door_controller : MonoBehaviour
{

    [SerializeField]
    private Animator myDoor = null;

    private int unitsInsideCount = 0;
    private bool IsDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        unitsInsideCount++;
        if (!IsDoorOpen)
        {
            IsDoorOpen = true;
            myDoor.Play("Opening", 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        unitsInsideCount--;
        if (unitsInsideCount <= 0 && IsDoorOpen)
        {
            IsDoorOpen = false;
            unitsInsideCount = 0;
            myDoor.Play("Closing", 0, 0.0f);
        }
    }

}