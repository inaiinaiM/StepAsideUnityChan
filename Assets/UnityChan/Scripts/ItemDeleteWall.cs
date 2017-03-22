using UnityEngine;
using System.Collections;

public class ItemDeleteWall : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//UnityちゃんとWallの距離
	private float distance;

	// Use this for initialization
	void Start () {
		
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");
		//Unityちゃんとwallの位置（z座標）の差を求める
		this.distance = unitychan.transform.position.z - this.transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんの位置に合わせてwallの位置を移動
		this.transform.position = new Vector3 (0, this.transform.position.y, this.unitychan.transform.position.z - distance);
		
	}

	//トリガーモードで他のオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider other) {

		//objectに衝突した場合
		if (other.gameObject.tag == "CoinTag" || other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag") {
			//接触したオブジェクトを破棄
			Destroy (other.gameObject);
		}
}
}
