using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour {
    private Playerscript playerscript;
    int health;
    GUIStyle guiStyle;
    bool guiStyleSetup = false;

    void OnGUI()
    {
        if (guiStyleSetup == false)
        {
            guiStyle = new GUIStyle(GUI.skin.label);
            guiStyle.fontSize = 40;
            guiStyleSetup = true;
        }
        GUI.Label(new Rect(10, 10, 400, 400), "Health: " + health, guiStyle);
    }



    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        health = Playerscript.Playerhealth;
    }
}