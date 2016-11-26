using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX=1,
        MouseY=2
    }

    public RotationAxes axes = RotationAxes.MouseY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0;

    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if(body!=null)
        {
            body.freezeRotation = true;
        }
    }

	// Update is called once per frame
	void Update () {
	    if(axes == RotationAxes.MouseX)
        {
            //horizontal rotation
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0, Space.Self);
        } 
        else if (axes == RotationAxes.MouseY)
        {
            //vertical rotation
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            //hor and vert rotation
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
	}
}
