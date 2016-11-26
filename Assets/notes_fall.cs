using UnityEngine;
using System.Collections;
using MidiJack;

public class notes_fall : MonoBehaviour
{

    public float fallSpeed = 0.5f;
    //public float spinSpeed = 250.0f;
    //public float spinSpeed = 250.0f;
    new AudioSource audio;
    //public float spinSpeed = 250.0f;
    //public float spinSpeed = 250.0f;
    
    public MidiDriver midi;

    void Start()
    {
       audio = GetComponent<AudioSource>();
    }
    void Update()
    {

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        if (transform.position.y < -2.00F)
        {
            transform.Translate(new Vector3(0, 7.036F, 0));
        }
    }
    void OnTriggerEnter(Collider coll)
    {
        audio.Play();
        Debug.Log("Collision Detected!");
    }
}