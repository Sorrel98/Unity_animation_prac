using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    private bool isJumping;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(moveX, 0f, moveZ);
        bool isMove = moveVector.magnitude > 0;
        animator.SetBool("isMove", isMove);
        if (isMove)
        {
            animator.transform.forward = moveVector;
        }
        transform.Translate(new Vector3(moveX, 0f, moveZ).normalized * Time.deltaTime * 5f);


        if (Input.GetButtonDown("space"))
        {
            animator.SetTrigger("jumpTrigger");
            jump();
        }
    }

    void jump()
    {
        if (!isJumping)
            return;
        Debug.Log("jump");
        
    }
}