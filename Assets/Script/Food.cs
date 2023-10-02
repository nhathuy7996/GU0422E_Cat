using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public bool isPlayer = false;
    [SerializeField] private float point = 5;
    [SerializeField] private int count;
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
            PlayerStat.instance.Eat(point);
            --count;
        }
        if (count <= 0)
        {
            gameObject.SetActive(false);
            UIController.Instant.F_btn_image.SetActive(false);
        }
    }
  
}
