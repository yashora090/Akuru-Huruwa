using UnityEngine;
using System.Collections;

public class Effects : MonoBehaviour {

	public Transform pointerPrefab;
<<<<<<< HEAD
	private Object path;
=======
	private Object pen;
>>>>>>> 674f85493a67507fd5eb89c1bf00814c3541af52
	// Use this for initialization

	//comment testing
	//comment 2
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if(touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
				Vector3 touchPosition=Camera.current.ScreenToWorldPoint(touch.position);
				touchPosition.z=0;
<<<<<<< HEAD
				path=Instantiate(pointerPrefab,touchPosition,Quaternion.identity);
=======
				pen=Instantiate(pointerPrefab,touchPosition,Quaternion.identity);
>>>>>>> 674f85493a67507fd5eb89c1bf00814c3541af52
			}

		}
	}
}
