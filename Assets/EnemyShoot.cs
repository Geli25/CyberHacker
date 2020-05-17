using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject shot;
    public Transform ShotSpawn1;
    public Transform ShotSpawn2;
    public Transform ShotSpawn3;
    public Transform ShotSpawn4;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Fire", 1f, 0.2f);
    }
    // Update is called once per frame
    void Fire()
    {
        Vector3[] Spawnpositions = new Vector3[] {ShotSpawn1.position, ShotSpawn2.position, ShotSpawn3.position,ShotSpawn4.position};
        Quaternion[] SpawnRotations = new Quaternion[] {ShotSpawn1.rotation, ShotSpawn2.rotation, ShotSpawn3.rotation,ShotSpawn4.rotation};
        for (int i = 0; i < Spawnpositions.Length; i++)
        //this code was initially int i=1; which means that it instantiates on DATA1
        //NOT DATA0, all arrays start listing at 0, so that was why there was only 3 sides were shooting
        {
            GameObject newshot = Instantiate(shot, Spawnpositions[i], SpawnRotations[i]) as GameObject;
            
        }
        //additional note: remember that 'for' means to go through the list, so the order matters in arrays, so
        //when the i++ is in effect it is repeating the same command by going down the list
        //this is why ArrayIndexOut of Range error is intact when the number is bigger than the length
        //because there are no additional items, therefore null
    }
}

