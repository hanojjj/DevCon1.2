using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyYellowDoor : MonoBehaviour
{
    [SerializeField]
    public GameObject yellowDoor;

    void Start()
    {
        yellowDoor = GameObject.FindGameObjectWithTag("yellowDoor");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject && SkinSwitcher.isYellow == true)
        {
            Destroy(yellowDoor);
            //Debug.Log("Collision Detected");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject && SkinSwitcher.isYellow == true)
        {
            Destroy(yellowDoor);
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