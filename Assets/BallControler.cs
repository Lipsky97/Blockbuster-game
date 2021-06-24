using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public int hp = 3;
    public float speed = 5f;
    public Text healthTxt;
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        healthTxt.text = hp.ToString();
        if(hp < 1)
        {
            hp = 3;
            gameObject.SetActive(false);
            spawner.GetComponent<BrickSpawner>().ResetLevel();
            gameObject.SetActive(true);
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
    }

    public void subHp()
    {
        hp -= 1;
    }
}
