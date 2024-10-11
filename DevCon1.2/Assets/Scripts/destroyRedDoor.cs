using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyRedDoor : MonoBehaviour
{
    [SerializeField]
    public GameObject redDoor;
   
    void Start()
    {
        redDoor = GameObject.FindGameObjectWithTag("redDoor");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject && SkinSwitcher.isRed == true)
        {
            Destroy(redDoor);
            //Debug.Log("Collision Detected");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject && SkinSwitcher.isRed == true)
        {
            Destroy(redDoor);
            //Debug.Log("Collision Detected");
        }
    }
}




/*
if (other.gameObject && SkinSwitcher.isYellow == true)
{
    Destroy(yellowDoor);
    Debug.Log("Collision Detected");
}
if (other.gameObject && SkinSwitcher.isRed == true)
{
    Destroy(redDoor);
    Debug.Log("Collision Detected");
}
*/