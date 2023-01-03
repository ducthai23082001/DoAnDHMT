using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PersonController : MonoBehaviour
{
    // Start is called before the first frame update
    int heart = 100;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var position = GetComponent<Rigidbody>().position;
        if (position.y < -3)
        {
            SceneManager.LoadScene(2);
        }

        if (position.x < 515)
        {
            Door1Controller.Instance.CloseDoor();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Spider_Queen_Collider")
        {
            calHeart(1);
        }

        if (GetComponent<Rigidbody>().position.y >= 1.45f)
        {
            if (other.gameObject.tag == "Brick1")
            {
                other.gameObject.transform.position = new Vector3(530.58f, 1.0f, -1265.7f);
                Door1Controller.Instance.OpenDoor();
            }
            else if (other.gameObject.tag == "Brick2")
            {
                other.gameObject.transform.position = new Vector3(298.07f, 1.0f, -1245.84f);
                Debug.Log(Door2Controller.Instance);
                Door2Controller.Instance.OpenDoor();
            }
            else if (other.gameObject.tag == "Brick3")
            {
                other.gameObject.transform.position = new Vector3(319.39f, 1.0f, -127.06f);
                Door3Controller.Instance.OpenDoor();
            }
        }

        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Car")
        {
            calHeart(1);
        }
        else if (other.gameObject.tag == "Heart")
        {
            other.gameObject.SetActive(false);
            calHeart(2);
        }
    }

    void OnCollisionStay(Collision other)
    {
        
        //if (other.gameObject.name.Contains("SpearD"))
        //{
        //    calHeart(1);
        //}
    }

    void checkDead()
    {
        if (heart < 1)
            SceneManager.LoadScene(2);
    }

    void calHeart(int type)
    {
        TextMeshProUGUI healthText = GameObject.Find("HP").GetComponent<TextMeshProUGUI>();

        if (type == 1)
        {
            heart -= 20;
            if (heart < 1) heart = 0;
            checkDead();
        }
        else if(type == 2)
        {
            heart += 20;
            if (heart > 100) heart = 100;
        }

        healthText.text = heart.ToString() + "/100";
    }
}
