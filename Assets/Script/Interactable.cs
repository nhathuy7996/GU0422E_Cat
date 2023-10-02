using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool isPlayer = false;

    private void Update()
    {
        if (isPlayer)
        {
            Vector2 treePos = Camera.main.WorldToScreenPoint(this.transform.position);
            UIController.Instant.F_btn_image.transform.position = treePos;
            UIController.Instant.F_btn_image.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") )
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
}
