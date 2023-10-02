using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public bool isPlayer = false;
    [SerializeField] private float point = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            isPlayer = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isPlayer)
        {
            PlayerStat.instance.Drink(point);
        }
    }
}
