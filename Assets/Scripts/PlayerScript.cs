using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移に必要！

public class PlayerScript : MonoBehaviour {
	
	float speed = 10.0f;//Playerの移動スピード

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Move ();//Playerを移動させる関数
	}

	//当たり判定検知(isTriggerにチェック入れる！)
	void OnTriggerEnter(Collider other){

		//当たった相手のtagがEnemyだった時
		if(other.gameObject.tag == "Enemy"){
			SceneManager.LoadScene ("GameOverScene");//GameOverSceneにシーン遷移
		}
	}

	//Playerを移動させる関数
	void Move()
	{
		//右キー押した時
		if(Input.GetKey("up") == true){
			this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		//下キー押した時
		if(Input.GetKey("down") == true){
			this.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		//右キーした時
		if(Input.GetKey("right") == true){
			this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		//左キー押した時
		if(Input.GetKey("left") == true){
			this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);//"this"てのはアタッチしてるオブジェクト自身のこと
		}
	}
}
