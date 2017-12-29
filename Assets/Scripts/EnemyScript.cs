using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	float speed = 10f;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 10f);//10秒後にDestroy
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += this.transform.forward * speed * Time.deltaTime;//常にEnemyにとっての正面方向(z軸方向)に向かってく
	}
}
