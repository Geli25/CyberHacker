using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3trigger : MonoBehaviour
{
    public GameObject Enemies;
    public GameObject dummy2;

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
            print("player exited trigger");
            Destroy(dummy2.gameObject);
        }
    }
}
