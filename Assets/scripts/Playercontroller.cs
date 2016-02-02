using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour 
{
	public float speed;
	private int count;	// for counting the pickups
	public Text counttext;
	public Text wintext;

	void Start () 
	{
		count = 0;
		SetCountText();
		wintext.text = "";
	}

	void FixedUpdate()
	{

	float moveHorizontal = Input.GetAxis("Horizontal");
	float moveVertical = Input.GetAxis("Vertical");

	Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

	rigidbody.AddForce(movement * speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other) 
	{
				if (other.gameObject.tag == "Pickup")
		{
						other.gameObject.SetActive (false);
						count++;
						SetCountText();
		}
	}

	void SetCountText() 
	{
		counttext.text = "Count: " + count.ToString ();
		if (count >= 9) 
		{
						wintext.text = "YOU WIN!";
						Application.LoadLevel("EndGame");
		}
	}
}
