using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public enum State { Wander, Still, Spin };
    private float counter = 0;
    public float speed = 15;
    public State enemyState = State.Still;
	// Use this for initialization
	void Start () {
        enemyState = (State)Random.Range(0, 4);
	}
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
        if (counter > 2)
        {
            counter = 0;
            enemyState = (State)Random.Range(0,4);
        }
        switch (enemyState)
        {
            case State.Wander:
                transform.Translate(transform.forward * Time.deltaTime * speed);
                transform.Rotate(new Vector3(0,1,0),Random.Range(-20,20));
                break;
            case State.Spin:
                transform.Rotate(new Vector3(0,1,0),speed*4* Time.deltaTime);
                break;
            default:
                break;
        }
	}
}
