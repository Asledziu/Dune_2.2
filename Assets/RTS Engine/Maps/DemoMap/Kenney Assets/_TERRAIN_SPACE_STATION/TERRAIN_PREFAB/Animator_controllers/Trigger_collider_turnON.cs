using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_collider_turnON : MonoBehaviour

{

    public GameObject Turn_On;

    private void OnTriggerEnter()
    {
        Turn_On.SetActive(true);
        gameObject.SetActive(false);
    }

}
