using UnityEngine;
using System.Collections;

public class fur_elise_drop : MonoBehaviour {
     public float fallSpeed = 0.41f;
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        //Debug.Log(transform.position.y.ToString());
        if (transform.position.y < -8.50F)
        {
            transform.position = new Vector3(transform.position.x, 9.42f, transform.position.z);
        }
    }
}
