using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour {
    public GameObject bomb;
    public Transform bombspawn;
	// Use this for initialization
	void Start () {
        InvokeRepeating("dropBomb", 1f, 5f);
    }
	
	// Update is called once per frame
	void dropBomb () {
        GameObject newbomb = Instantiate(bomb, bombspawn.position, bombspawn.rotation) as GameObject;
        print("bomb created");
	}
}
