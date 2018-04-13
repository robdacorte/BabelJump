using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject platform;
	public int numberOfPlatforms = 200;
	float minY = .2f;
	float maxY = 1.5f;
	float levelWidth = 3f;

	// Use this for initialization
	void Start () {
		Vector3 spanwPosition = new Vector3();
		for (int i = 0; i < numberOfPlatforms; i++){
			spanwPosition.y += Random.Range(minY, maxY);
			spanwPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(platform, spanwPosition, Quaternion.identity);
		}
	}
}
