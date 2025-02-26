using UnityEngine;
using System.Collections;

public class RotateSun : MonoBehaviour {


	private float mouseXAmount;
	public float speed = 100; // should be faster rotation speed than Earth

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButton(0)){
			mouseXAmount = -Input.GetAxis("Mouse X") * 3f;
			
			transform.Rotate(0,mouseXAmount,0);
		}
		if(Input.GetKey(KeyCode.Delete)){
			transform.Rotate(0,0.2f,0);

		}
		if(Input.GetKey(KeyCode.PageDown)){
			transform.Rotate(0,-0.2f,0);
			
		}
		if(Input.GetKey(KeyCode.Home)){
			transform.Rotate(0.2f,0,0);
			
		}
		if (Input.GetKey(KeyCode.End))
		{
			transform.Rotate(-0.2f, 0, 0);

		}

		CustomRotate();

    }

    public void CustomRotate()
    {
        // Rotate the GameObject around its Y axis at 'speed' degrees per second
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
