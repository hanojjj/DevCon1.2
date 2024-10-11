//using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SkinSwitcher : MonoBehaviour
{
    public Renderer render;
    public GameObject player;

    public Material skin1;
    public Material skin2;
    public Material skin3;
    public Material skin4;

    static public int skin;

    static public bool isGreen;
    static public bool isRed;
    static public bool isYellow;
    static public bool isBlue;


    // Start is called before the first frame update
    void Start()
    {
        skin = 1;

        isGreen = true;
        isRed = false;
        isYellow = false;
        isBlue = false;

        player = player.GetComponent<GameObject>();

        render = player.GetComponent<Renderer>();
        render.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Input Found");
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            skin = skin + 1;
            ChangeSkin();
            Debug.Log("Input Found");
        }
        else if (skin >= 5)
        {
            skin = 1;
            ChangeSkin();
        }



    }


    void ChangeSkin()
    {
        if (skin == 1)
        {
            render.material = skin1;

            isGreen = true;
            isRed = false;
            isYellow = false;
            isBlue = false;
        }
        if (skin == 2)
        {
            render.material = skin2;

            isGreen = false;
            isRed = false;
            isYellow = false;
            isBlue = true;
        }
        if (skin == 3)
        {
            render.material = skin3;

            isGreen = false;
            isRed = false;
            isYellow = true;
            isBlue = false;
        }
        if (skin == 4)
        {
            render.material = skin4;

            isGreen = false;
            isRed = true;
            isYellow = false;
            isBlue = false;
        }
    }

}
