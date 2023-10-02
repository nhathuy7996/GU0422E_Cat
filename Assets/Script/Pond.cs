using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Pond : MonoBehaviour
{
    public bool isPlayer = false;
    [SerializeField] private float point = 5;
    [SerializeField] private int count;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayer = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            isPlayer = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isPlayer)
        {
            PlayerStat.instance.Drink(point);
            --count;
        }
        if (count <= 0) {
            Destroy(gameObject);
        }
    }
}
