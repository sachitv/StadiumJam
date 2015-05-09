using UnityEngine;
using System.Collections;

public class Picker : MonoBehaviour {

	// Use this for initialization
	public GameObject camera;

	private GameObject carriedObject;

	bool carrying;

	void Start()
	{
		carrying = false;
		carriedObject = null;
	}
	
	// Update is called once per frame
	void Update () {
		if(!carrying)
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				Ray r = camera.camera.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
				RaycastHit hit;

				if(Physics.Raycast(r, out hit))
				{
					if(hit.distance < 2)
					{
						Pickupable p = hit.collider.gameObject.GetComponent<Pickupable>();

						if(p)
						{
							carrying = true;
							carriedObject = hit.collider.gameObject;
						}
					}
				}
			}
		}

		else
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				carriedObject = null;
				carrying = false;
			}
			if(carriedObject)
			{
				carriedObject.transform.position = Vector3.Lerp(carriedObject.transform.position, transform.position + transform.forward*2, Time.deltaTime*60);
			}
		}
	
	}
}
