using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCamera : MonoBehaviour
{
    [SerializeField] Camera camera = default;
    public Rigidbody2D rb;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
// First Background
        if (rb.transform.position.y >= -3.42 && rb.transform.position.y < 6f)
        {
            camera.transform.position = new Vector3(0.0f, 0.0f, -10.0f);
        }

        else if (rb.transform.position.y >= 6f && rb.transform.position.y < 17.5f)
        {
            camera.transform.position = new Vector3(0.0f, 11.7f, -10.0f);
            
        }
        else if (rb.transform.position.y >= 17.5f && rb.transform.position.y < 29f)
        {
            camera.transform.position = new Vector3(0.0f, 23.4f, -10.0f);

        }
        else if (rb.transform.position.y >= 29f && rb.transform.position.y < 40.5f)
        {
            camera.transform.position = new Vector3(0.0f, 35.1f, -10.0f);

        }
        else if (rb.transform.position.y >= 40.5f && rb.transform.position.y < 52f)
        {
            camera.transform.position = new Vector3(0.0f, 46.8f, -10.0f);
        }

// Second Background
        else if (rb.transform.position.y >= 52f && rb.transform.position.y < 63.5f)
        {
            camera.transform.position = new Vector3(0.0f, 58.5f, -10.0f);
        }
        else if (rb.transform.position.y >= 63.5f && rb.transform.position.y < 75f)
        {
            camera.transform.position = new Vector3(0.0f, 70.2f, -10.0f);
        }
        else if (rb.transform.position.y >= 75f && rb.transform.position.y < 86.5f)
        {
            camera.transform.position = new Vector3(0.0f, 81.9f, -10.0f);
        }
        else if (rb.transform.position.y >= 86.5f && rb.transform.position.y < 98f)
        {
            camera.transform.position = new Vector3(0.0f, 93.6f, -10.0f);
        }
        else if (rb.transform.position.y >= 98f && rb.transform.position.y < 109.5f)
        {
            camera.transform.position = new Vector3(0.0f, 105.3f, -10.0f);
        }

// Third Background
        else if (rb.transform.position.y >= 109.5f && rb.transform.position.y < 121f)
        {
            camera.transform.position = new Vector3(0.0f, 117f, -10.0f);
        }
        else if (rb.transform.position.y >= 121f && rb.transform.position.y < 132.5f)
        {
            camera.transform.position = new Vector3(0.0f, 128.7f, -10.0f);
        }
        else if (rb.transform.position.y >= 132.5f && rb.transform.position.y < 144f)
        {
            camera.transform.position = new Vector3(0.0f, 140.4f, -10.0f);
        }
        else if (rb.transform.position.y >= 144f && rb.transform.position.y < 155.5f)
        {
            camera.transform.position = new Vector3(0.0f, 152.1f, -10.0f);
        }
        else if (rb.transform.position.y >= 155.5f && rb.transform.position.y < 167f)
        {
            camera.transform.position = new Vector3(0.0f, 163.8f, -10.0f);
        }
    }
}
