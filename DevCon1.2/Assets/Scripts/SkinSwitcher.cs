using JetBrains.Annotations;
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
    public bool magician;
    public bool cowboy;


    // Start is called before the first frame update
    void Start()
    {
        magician = true;
        cowboy = false;

        player = GameObject.FindGameObjectWithTag("Player");
        render = player.GetComponent<Renderer>();
        render.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            magician = false;
            cowboy = true;
            ChangeSkin();
        }
        else if (Input.GetKeyUp(KeyCode.J))
        {
            magician = true;
            cowboy = false;
            ChangeSkin();
        }



    }


    void ChangeSkin()
    {
        if (magician == true)
        {
            render.material = skin1;
        }
        if (cowboy == true)
        {
            render.material = skin2;
        }
    }

}
