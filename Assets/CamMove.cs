using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
	public Rigidbody2D Pl;
	public Camera Cm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Cm.transform.position = Pl.transform.position + new Vector3(0,0,-10);
    }
}
