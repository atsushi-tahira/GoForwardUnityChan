using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;
	// 消滅位置
	private float deadLine = -11;
	private AudioSource audio;
	void Start(){
		audio = this.gameObject.GetComponent<AudioSource>();
	}
		
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "object") {
			audio.Play ();
		}
	}
}