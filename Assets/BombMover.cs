using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMover : MonoBehaviour {
    public float Speed;
    private float timer;
    public GameObject explosion;

    // Use this for initialization
    void Start () {
        explosion.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject target = GameObject.FindWithTag("Player");
        timer += Time.deltaTime;
        float adjustedSpeed = Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, adjustedSpeed);

        if (timer > 4.0f)
        {
            explosion.SetActive(true);
            StartCoroutine(Extinguish());
        }
	}

    IEnumerator Extinguish()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0.4f);
        Destroy(this.gameObject);
    }

    void OnTriggerEnter (Collider RightPerson)
    {
        if (RightPerson.tag=="wall")
        {
            explosion.SetActive(true);
            Debug.Log("bomb ran into wall");
            StartCoroutine(Extinguish());
        }

        if (RightPerson.tag == "Player")
        {
            explosion.SetActive(true);
            StartCoroutine(Extinguish());
            Debug.Log("bomb ran into player");
        }
    }
}
