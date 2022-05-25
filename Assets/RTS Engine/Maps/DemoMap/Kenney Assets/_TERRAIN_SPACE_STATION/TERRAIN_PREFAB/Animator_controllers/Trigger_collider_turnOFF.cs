using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_collider_turnOFF : MonoBehaviour

{

    public GameObject Turn_Off;

    private void OnTriggerEnter()
    {
        Turn_Off.SetActive(false);
        gameObject.SetActive(false);
    }

}
