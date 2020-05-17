using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(DestroySound());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator DestroySound()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(this.gameObject);
    }
}
