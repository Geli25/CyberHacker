using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject shot;
    public Transform ShotSpawn;
    public float fireRate;
    private float nextFire;
    private float myTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            nextFire = myTime + fireRate;

            GameObject newshot = Instantiate(shot, ShotSpawn.position, ShotSpawn.rotation) as GameObject;
       
        }
    }

}
