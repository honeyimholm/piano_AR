using UnityEngine;
using System.Collections;
using MidiJack;

public class fuck : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Test!");
    }
	
	// Update is called once per frame
	void Update () {
            bool i = MidiMaster.GetKeyDown(MidiChannel.All, 0x15);
            //Debug.Log(i);
        }
	}
