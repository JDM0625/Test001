using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class Move : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    int plus;

    float x;
    float y;
    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, 0, y) * speed * Time.deltaTime;
        AddScale();
        Rotation();
    }
    void AddScale()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localScale = new Vector3(transform.localScale.x + plus, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.localScale = new Vector3(transform.localScale.x  , transform.localScale.y + plus, transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + plus);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            transform.localScale = new Vector3(transform.localScale.x - plus, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - plus, transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z - plus);
        }
    }

    void Rotation()
    { 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles. y, transform.eulerAngles.z + plus);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x , transform.eulerAngles.y, transform.eulerAngles.z - plus);
        }
    }
}
