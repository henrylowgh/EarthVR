using UnityEngine;
using System.Collections;

public class RotateEarth : MonoBehaviour {

	private float mouseXAmount, mouseYAmount;
	public float speed = 10f;  // Rotation speed
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(1)){
			mouseXAmount = -Input.GetAxis("Mouse X") * 2f;
			mouseYAmount = Input.GetAxis("Mouse Y") * 2f;
			transform.Rotate(mouseYAmount,mouseXAmount,0,Space.World);
		}

		CustomRotate();

	}

	public void CustomRotate()
	{
        // Rotate the GameObject around its Y axis at 'speed' degrees per second
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }

}
