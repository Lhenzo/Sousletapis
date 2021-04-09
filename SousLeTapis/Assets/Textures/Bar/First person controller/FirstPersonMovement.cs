using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    Vector2 velocity;
    private Animator m_animator;
    private void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        velocity.y = Input.GetAxis("Vertical") * speed;
        velocity.x = Input.GetAxis("Horizontal") * speed;
        transform.Translate(velocity.x * Time.deltaTime, 0, velocity.y * Time.deltaTime);
    }
    private void Update()
    {
        if (m_animator != null) 
        {
            m_animator.SetFloat("Speed", velocity.magnitude);
        }
    }
}
