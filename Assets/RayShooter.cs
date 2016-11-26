using UnityEngine;
using System.Collections;

public class RayShooter : MonoBehaviour {
    private Camera _camera;

	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                StartCoroutine(SphereIndicator(hit.point));
                Debug.Log("Hit " + hit.point);
            }
        }
	}
    //IEnumerator is interface for enumerators -> lets you cycle through a collection...I think
    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        yield return new WaitForSeconds(1);
        Destroy(sphere); //stay for one second then go away
    }
}
