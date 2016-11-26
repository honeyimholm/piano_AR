using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0, Space.Self);
    }
}
