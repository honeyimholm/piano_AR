using UnityEngine;
using System.Collections;
using MidiJack;

public class midi_detected_key_4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        bool key_down = MidiMaster.GetKeyDown(MidiChannel.All, 0x19);
        if (key_down)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_Color", Color.red);
            Debug.Log("here!");
        }
        else if (MidiMaster.GetKeyUp(MidiChannel.All, 0x19))
        {
            Debug.Log("here! now");
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_Color", Color.black);
        }
    }
}
