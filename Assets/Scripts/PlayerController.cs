using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed = 10; 

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void FixedUpdate () {
        //入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(x * speed, 0, z * speed);
	}
}
