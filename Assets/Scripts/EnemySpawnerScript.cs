using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {
	public GameObject enemy;//UnityからGameObject型のEnemyのPrefabをくっつけたいから、変数もGameObject型！
	[SerializeField] float enemySpawnTimer;//Enemyを生成させる頻度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		enemySpawnTimer += Time.deltaTime;//1フレームごとに時間足してく！→実質タイマー

		if(enemySpawnTimer > 1){//1秒ごとにEnemy生成！
			Instantiate (enemy, this.transform.position + this.transform.right * Random.Range(-10f,10f), this.transform.rotation);
			enemySpawnTimer = 0;//enemy生成したらタイマーゼロ
		}

	}
}
