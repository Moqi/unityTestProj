using UnityEngine;
using System.Collections;

public class MakeEnemies : MonoBehaviour {

	public GameObject Enemy1, Enemy2;
	public int NumEnemies;
	
	// Use this for initialization
	void Start () {
		Vector3 pos;
		for (int i = 0; i < NumEnemies; i++)
		{
			pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
			if (Random.Range(0, 2) == 0)
			{
				Instantiate(Enemy1, pos, Quaternion.identity);
			}
			else
			{
				Instantiate(Enemy2, pos, Quaternion.identity);
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
