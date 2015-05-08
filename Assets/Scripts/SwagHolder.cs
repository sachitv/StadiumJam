using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwagHolder : MonoBehaviour {

	public int MAX_SWAG_AMOUNT;
	private int current_swag;

	public GameObject SwagUI;
	public GameObject SwagArticle;

	public void refillSwag()
	{
		current_swag = MAX_SWAG_AMOUNT;

		SwagUI.GetComponent<Text>().text = "Swag : " + current_swag;
	}

	public void throwSwag()
	{
		if(current_swag > 0)
		{
			current_swag--;
			SwagUI.GetComponent<Text>().text = "Swag : " + current_swag;

			Vector3 pos = gameObject.transform.position;
			pos.y+=1;
			GameObject a = GameObject.Instantiate(SwagArticle, pos, Quaternion.identity) as GameObject;
			Vector3 targetvelocity = gameObject.transform.forward;
			targetvelocity*=5;
			targetvelocity.y+=2;
			a.GetComponent<Rigidbody>().velocity = targetvelocity;
		}
	}

	public int getSwag()
	{
		return current_swag;
	}

	void Start()
	{
		current_swag = 0;
		SwagUI.GetComponent<Text>().text = "Swag : " + current_swag;
		Physics.gravity = new Vector3(0, -10.0F, 0);
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			throwSwag();
		}
	}

}
