using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, -50 * Time.deltaTime * speed, 0, Space.World);

        if (this.transform.rotation.y > 49)
        {
            transform.Rotate(0, -100 * Time.deltaTime * speed, 0);
        }

        if (this.transform.rotation.y < -49)
        {
            transform.Rotate(0, 100 * Time.deltaTime * speed, 0);
        }
    }
}
