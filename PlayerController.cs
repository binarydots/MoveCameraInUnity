using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;

	public Text scoreText;

	private int score;

	//  Initial calculations
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		score = 0;

		updateScoreText ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log (other.gameObject.tag);

		updateScoreText ();
	}


	void updateScoreText()
	{
		scoreText.text = "Score : " + score.ToString ();
	}

}
