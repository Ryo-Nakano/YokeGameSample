using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	[SerializeField] float speed = 6f;
	[SerializeField] int hp = 3;
	AudioClip damageSound;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
		damageSound = Resources.Load <AudioClip>("Sounds/Sound1");
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();//Playerを移動させる関数
	}

	//====HP実装ありの場合====
//	void OnTriggerEnter(Collider other){
//		if(other.gameObject.tag == "Enemy"){
//			if (hp > 1) {
//				audioSource.PlayOneShot (damageSound);
//				hp--;
//			} else {
//				SceneManager.LoadScene ("GameOverScene");
//			}
//
//		}
//	}

	//====HP実装無しの場合====
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Enemy"){
			SceneManager.LoadScene ("GameOverScene");
		}
	}

	//Playerを移動させる関数
	void Move()
	{
		if(Input.GetKey("up") == true){
			this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		if(Input.GetKey("down") == true){
			this.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		if(Input.GetKey("right") == true){
			this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		if(Input.GetKey("left") == true){
			this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);//"this"てのはアタッチしてるオブジェクト自身のこと
		}
	}
}
