using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Trigger : MonoBehaviour {
    public GameObject Enemies;
    public GameObject dummy1;

	// Use this for initialization
	void Start () {
        Enemies.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerExit(Collider player)
    {
        if (player.tag == "Player")
        {
            Enemies.SetActive(true);
            Destroy(dummy1.gameObject);
            print("player exited trigger");
        }
        //11/07: not setting the wall back on on trigger exit??
        //11/20: I know what is happening here, because the function is called on "Update", every frame
        //the stage1_enemy is gone it is going to disenable the wall, 
        //so it would conflict with the trigger command of enabling the wall
        //this has nothing to do with problems with setactive(true),because it works with all particle systems
    }
}
