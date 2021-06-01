using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroeScript : MonoBehaviour
{
    [SerializeField] private float speed = 3f; 
    [SerializeField] private int lives = 5;
    [SerializeField] private float jumpForce = 15f;


    private Rigidbody2D rb;
    private SpriteRender sprite;

    private void Awake()
    {
        rb = GetCompanent<Rigidbody2D>();
        sprite = GetCompanentInChildren<SpriteRender>();

    }

    private void Update()
    {
        if (Input.Getbutton("Horizontal"))
            Run();
    }

    private void Run()
    {
        Vector3 dir = transforme.right * Input.GetAxis("Horizontal");

        transforme.position = Vector3.MoveTowards(transforme.position, transforme.position + dir, speed * Time.deltaTime) ;
    }
}
