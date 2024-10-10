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
    public int skin;
    

    // Start is called before the first frame update
    void Start()
    {
        skin = 1;

        player = GameObject.FindGameObjectWithTag("Player");
        render = player.GetComponent<Renderer>();
        render.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            skin = skin + 1;
            ChangeSkin();
        }
        else if (Input.GetKeyUp(KeyCode.J))
        {
            skin = skin - 1;
            ChangeSkin();
        }



    }


    void ChangeSkin()
    {
        if (skin == 1)
        {
            render.material = skin1;
        }
        if (skin == 2)
        {
            render.material = skin2;
        }
    }

}
