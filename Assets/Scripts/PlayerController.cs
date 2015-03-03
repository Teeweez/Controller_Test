using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Boundary boundary;


	public GameObject shot;
	public GameObject superShot;
	public GameObject epicShot;
	public Transform shotSpawn;

	public float fireRate;
	public float superFireRate;
	public float epicFireRate;
	 
	private float nextFire;
	private float nextSuperFire;
	private float nextEpicFire;

	private DynamicDpad dpad;

	public void ShotWeb ()
	{
		if (Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource> ().Play ();
		}
	}

	public void ShotSuperWeb ()
	{
		if (Time.time > nextSuperFire) 
		{
			nextSuperFire = Time.time + superFireRate;
			Instantiate (superShot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource> ().Play ();
		}
	}

	public void ShotEpicWeb ()
	{
		if (Time.time > nextEpicFire) 
		{
			nextEpicFire = Time.time + epicFireRate;
			Instantiate (epicShot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource> ().Play ();
		}
	}
	void Start ()
	{
		dpad = gameObject.GetComponent<DynamicDpad>();
	}


	void FixedUpdate ()
	{

		//Vector3 direction = new Vector3(dpad.Axes.x * movementSpeed * dt, 0.0f, dpad.Axes.y * movementSpeed * dt);
		/*
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		*/
		float moveHorizontal = dpad.Axes.x;
		float moveVertical = dpad.Axes.y;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;
		
		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);
		
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}
}
