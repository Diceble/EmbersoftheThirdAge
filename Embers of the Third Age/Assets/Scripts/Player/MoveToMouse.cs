using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    public float walkingSpeed = 5f;
    public float runningSpeed = 7.5f;
    private Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, walkingSpeed * Time.deltaTime);
    }
}
