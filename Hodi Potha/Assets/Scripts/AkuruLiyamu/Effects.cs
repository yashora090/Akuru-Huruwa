using UnityEngine;
using System.Collections;

public class Effects : MonoBehaviour {

	public Transform pointerPrefab;
	private Object pen;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if(touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
				Vector3 touchPosition=Camera.current.ScreenToWorldPoint(touch.position);
				touchPosition.z=0;
				pen=Instantiate(pointerPrefab,touchPosition,Quaternion.identity);
			}

		}
	}
}
