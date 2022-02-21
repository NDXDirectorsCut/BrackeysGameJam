using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
	public float MvS = 15f;
	public Rigidbody2D Pl;	
	
	Vector2 MvM;	

	void Update()
    {
	//Input Handler
	float mY = Input.GetAxis ("Mouse Y");
	float mX = Input.GetAxis ("Mouse X");
	MvM.x = Input.GetAxisRaw("Horizontal");
	MvM.y = Input.GetAxisRaw("Vertical");
    }
	void FixedUpdate()
    {
	//Physics Handler	
	Pl.MovePosition(Pl.position + MvM * MvS * Time.fixedDeltaTime);
    }
}
