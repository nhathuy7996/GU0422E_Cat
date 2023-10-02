using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int score = 100;
    [SerializeField] private float speed;
    float Speedpoint = 1;
    float timer;
    [SerializeField] private List<Transform> SpawnPoints;

    public bool isChase = false;
    private Transform player;
    private Rigidbody2D body;

    public bool isPlayer = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
         
      isPlayer = player.gameObject.GetInstanceID() == other.gameObject.GetInstanceID();
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (player.gameObject.GetInstanceID() == other.gameObject.GetInstanceID())
        {
            isPlayer = false;
        }
    }
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    { if (isChase)
        {

            timer += Time.fixedDeltaTime;
            if (timer > 5f && Speedpoint<3)
            {
                ++Speedpoint;
                timer = 0;
            }
            //Vector3 dir = player.position - transform.position;
            //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


            Vector3 displacement = player.position - transform.position;
            displacement = displacement.normalized;
            if (Vector2.Distance(player.position, transform.position) > 0f)
                transform.position += displacement * speed *Speedpoint* Time.fixedDeltaTime;
        }
        if (Input.GetKeyDown(KeyCode.H) && isPlayer)
        {
            isChase = true;
            BossTrigger.Instant.bossStart = true;
        }
    }




}
