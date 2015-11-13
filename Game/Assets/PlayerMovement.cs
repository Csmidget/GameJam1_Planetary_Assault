using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float topSpeed = 40.0f;
	public float rot = 10.0f;
	public float accel = 0.0f;
	public float reverseSpeed = -20.0f;

	//Use Fixed Update because of the use of Physics
	void FixedUpdate()
	{
		Controls();
	}

	void Controls()
	{
		//Add force to move the player forwards
		GetComponent<Rigidbody2D>().AddForce(transform.up * accel);

		//WAS and Arrow Key Input
		//Forwards
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			//If W is pressed and accel is less than the top speed, increase accel
			if(accel < topSpeed)
			{
				accel += 25.0f * Time.deltaTime;
			}
			if(accel > topSpeed)
			{
				accel = 40.0f;
			}
		}

		//Reverse
		if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			//If S is pressed and accel is greater than the max reverse speed, decrease accel
			if(accel > reverseSpeed)
			{
				accel -= 25.0f * Time.deltaTime;
			}
			if(accel < reverseSpeed)
			{
				accel = -20.0f;
			}
		}

		//If idle, decay the accel back to 0. Due to floats being decimal, a range between 1 and -1 was needed to reset the speed back to 0,
		//as the chance of a float landing exactly on 0 is very small.
		if(!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
		{
			//Slow if moving backwards
			if(accel > 0.0f)
			{
				accel -= 15.0f * Time.deltaTime;
			}
			//Slow if moving forwards
			if(accel < 0.0f)
			{
				accel += 15.0f * Time.deltaTime;
			}
			//Set accel to 0 when it's between 1 and -1
			if(accel < 1.0f && accel > -1.0f)
			{
				accel = 0.0f;
			}
		}

		//Can't turn if stationary
		if(accel == 0.0f)
		{
			rot = 0;
		}
		//Set rotation back if accel is greater than 0
		else
		{
			rot = 10.0f;
		}

		//Rotation
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			//transform.Rotate(new Vector3(0, 0, rot) * Time.deltaTime);
			GetComponent<Rigidbody2D>().AddTorque(rot);
		}

		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			//transform.Rotate(new Vector3(0, 0, -rot) * Time.deltaTime);
			GetComponent<Rigidbody2D>().AddTorque(-rot);
		}
	}
}