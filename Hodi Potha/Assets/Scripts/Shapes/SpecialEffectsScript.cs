using UnityEngine;

public class SpecialEffectsScript : MonoBehaviour
{
	private static SpecialEffectsScript instance;
	

	public GameObject trailPrefab;
	public GameObject ball;
	
	void Awake()
	{
		instance = this;
	}
	
	/*void Start()
	{
		// Check prefabs

		if (trailPrefab == null)
			Debug.LogError("Missing Trail Prefab!");
	}*/
	


	public static GameObject MakeballTrail(Vector3 position)
	{
		if (instance == null)
		{
			Debug.LogError("There is no SpecialEffectsScript in the scene!");
			return null;
		}
		
		GameObject ball = Instantiate(instance.trailPrefab) as GameObject;
		ball.transform.position = position;

		return ball;
	}
}
