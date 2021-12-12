
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereCode : MonoBehaviour
{
    public static int points = 0;
    public Rigidbody rb;
    //Vector3 vector3 = new Vector3(-100, 0, 0);
    //public int speed = 50;
    //private int left_right = 20;
    public GameObject scoretext;
    private TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        // tìm component Rigidbody bên trong Sphere Object để liên kết nếu có
        //rb = GetComponent<Rigidbody>();
        text = scoretext.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        // AddForce() dùng để sinh lực tác động vào vật thể
        //rb.AddForce(vector3);
        //rb.AddForce(x, y, z);
        //rb.AddForce(0, 0, 100 * Time.deltaTime);// một giây tổng lực là 100
        //rb.AddForce(0, 0, speed * Time.deltaTime);// một giây tổng lực là 100

        //if (Input.GetKey(KeyCode.F))
        //{   // ForceMode.VelocityChange để đổi tốc độ tức thì
        //    rb.AddForce(-left_right * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);// một giây tổng lực là 100
        //}
        //if (Input.GetKey(KeyCode.J))
        //{
        //    rb.AddForce(left_right * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);// một giây tổng lực là 100
        //}

        //float moving = Input.GetAxis("Horizontal");
        //rb.AddForce(left_right * moving * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
    }

    // chạy 0.01 giây
    private void FixedUpdate()
    {
        //rb.AddForce(0, 0, speed * Time.deltaTime);// một giây tổng lực là 100
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Cylinder"))
        {
            points++;
            Debug.Log(points);
            text.text = "Score " + points;
            other.gameObject.SetActive(false);
            if (points == 10)
            {
                SceneManager.LoadScene("newgame");
                points = 0;
            }
        }
    }
}
