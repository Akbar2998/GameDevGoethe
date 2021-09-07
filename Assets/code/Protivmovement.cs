using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protivmovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationspeed;
    [SerializeField] Transform Player;

    Rigidbody2D rb;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Player.position - transform.position;
        float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion r = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, r, rotationspeed * Time.deltaTime);
    }

    void FixedUpdate() {
        rb.AddRelativeForce(new Vector3(0f, moveSpeed * Time.fixedDeltaTime, 0f));
    
    }


}
