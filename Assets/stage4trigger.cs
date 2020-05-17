using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage4trigger : MonoBehaviour {
    public GameObject Enemies;
    public GameObject dummy3;

    // Use this for initialization
    void Start()
    {
        Enemies.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider player)
    {
        if (player.tag == "Player")
        {
            Enemies.SetActive(true);
            Destroy(dummy3.gameObject);
            print("player exited trigger");
        }
    }
}
