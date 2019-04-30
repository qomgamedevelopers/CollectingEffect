using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public BezierCurve curve;
	float _timer;
	float _randomSpeed;

	void Start () {
		_randomSpeed = Random.Range(0.7f,1);
	}
	
	void Update () {
		_timer += Time.deltaTime*_randomSpeed;
		transform.position = curve.GetPoint(_timer);
	}
}
