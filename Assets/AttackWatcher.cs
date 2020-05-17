using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackWatcher : MonoBehaviour {
    [HideInInspector]
    public int enemyHealth = 5;
    public GameObject deathspawner;
    AudioSource damageSound;


	// Use this for initialization
	void Start () {
        damageSound = GetComponent<AudioSource>();
		
	}

    // Update is called once per frame
    void Update () {
        ;
        if (enemyHealth<=0)
        {
            Instantiate(deathspawner);
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.tag == "Shot")
        {
            enemyHealth -= 1;
            damageSound.Play();
            print("Enemy damage 1 taken");
        }
    }
}
