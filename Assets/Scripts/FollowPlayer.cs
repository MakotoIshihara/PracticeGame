using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform target;  //ターゲットへの参照
    public Vector3 offset;   //相対座標

    void Start() {
        offset = GetComponent<Transform>().position - target.position;
    }
	
	// Update is called once per frame
	void Update () {

        // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
        GetComponent<Transform>().position = target.position + offset;
	
	}
}
