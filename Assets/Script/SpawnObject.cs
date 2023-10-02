using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private List <GameObject> objects;
    [SerializeField] private List <Transform> spawnpoints;
    [SerializeField] private GameObject Spawn_object;
    [SerializeField] private int object_num;

    public bool isPlayer = false;
    public bool isFull;
    float timer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayer = true;

           
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            isPlayer = false;

            UIController.Instant.F_btn_image.SetActive(false);
        }
    }
    private void Update()
    {
        if (object_num <= 0)
        {
            isFull = false;
            timer += Time.deltaTime;
        }
        if (object_num == 3)
        {
            isFull = true;
         
        }
        if (timer > 5f && !isFull)
        {
            ObjectAdd();
            objects[FindObject()].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F) && isPlayer && object_num > 0)
        {
            Spawn();
        }

        if (isPlayer)
        {
            Vector2 treePos = Camera.main.WorldToScreenPoint(this.transform.position);
            UIController.Instant.F_btn_image.transform.position = treePos;
            UIController.Instant.F_btn_image.SetActive(true);
        }
    }
    public void Spawn()
    {
         objects[FindObjectActive()].SetActive(false);
         Instantiate(Spawn_object, spawnpoints[Random.Range(0, spawnpoints.Count)].position, Quaternion.identity);
        ObjectMinus();
    }
 
    private void ObjectAdd()
    {
        ++object_num;
        timer = 0;
    }
    private void ObjectMinus()
    {
        --object_num;
    }
    private int FindObject()
    {
        for (int i = 0;  i < objects.Count; ++i) 
            {
            if (!objects[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
    private int FindObjectActive()
    {
        for (int i = 0; i < objects.Count; ++i)
        {
            if (objects[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
    

}
