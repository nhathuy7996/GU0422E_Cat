using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] float speed;
    private Animator anim;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        body.velocity = new Vector2 (x*speed+Time.deltaTime, y * speed + Time.deltaTime);
        if (x ==1 && y==0)
        {
            anim.SetBool("walkinR", true);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", false);

        }
        if (x ==-1&& y==0) 
        { 
            anim.SetBool("walkinR", false) ;
            anim.SetBool("walkinL", true);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", false);


        }
        if (x == 0 && y==1)
        {
            anim.SetBool("walkinR", false);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", true);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", false);

        }
        if (x == 0 && y == -1)
        {
            anim.SetBool("walkinR", false);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", true);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", false);

        }
        if (x == 1 && y == -1)
        {
            anim.SetBool("walkinR", false);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", true);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", false);

        }
        if (x == -1 && y == -1)
        {
            anim.SetBool("walkinR", false);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", true);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", false);

        }
        if(x == -1 && y == 1)
        {
            anim.SetBool("walkinR", false);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", true);

        }
        if (x == 1 && y == 1)
        {
            anim.SetBool("walkinR", false);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", true);
            anim.SetBool("cheoUL", false);
        }
        if (x == 0 &&y == 0)
        {
            anim.SetBool("walkinR", false);
            anim.SetBool("walkinL", false);
            anim.SetBool("walkinU", false);
            anim.SetBool("walkin", false);
            anim.SetBool("cheoR", false);
            anim.SetBool("cheoL", false);
            anim.SetBool("cheoUR", false);
            anim.SetBool("cheoUL", false);

        }
        
    }
}
