using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBlueDoor : MonoBehaviour
{
    [SerializeField]
    public GameObject blueDoor;
  
    void Start()
    {
        blueDoor = GameObject.FindGameObjectWithTag("blueDoor");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject && SkinSwitcher.isBlue == true)
        {
            Destroy(blueDoor);
            //Debug.Log("Collision Detected");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject && SkinSwitcher.isBlue == true)
        {
            Destroy(blueDoor);
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