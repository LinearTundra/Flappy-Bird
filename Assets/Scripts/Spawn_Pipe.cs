using UnityEngine;
using Random = System.Random;

public class Spawn_Pipe : MonoBehaviour
{
    public GameObject pipe1;
    public GameObject pipe2;
    public GameObject pipe3;
    public GameObject pipe4;
    [SerializeField] private float spawn_time;
    private float time;
    private float random_pos;
    private Vector3 position;
    private Random random = new Random();
    public Score_Manager sm;
    
    void Start() {
        time = 0f;
        position = transform.position + new Vector3 (0, 7, 0);
    }

    void Update() {
        time += Time.deltaTime;
        if (time > spawn_time) {
            if ( sm.score < 15 ) {
                spawn(pipe1);
            }
            else if ( sm.score < 25 ) {
                spawn(pipe2);
            }
            else if ( sm.score < 40 ) {
                spawn(pipe3);
            }
            else {
                spawn(pipe4);
            }
             time = 0;
        }
        
    }

    private void spawn(GameObject pipe) {
        Instantiate(pipe, position, Quaternion.identity);
        random_pos = random.Next(4, 7) + (float)random.NextDouble();
        position = transform.position + new Vector3 (0, random_pos, 0);
    }
}
