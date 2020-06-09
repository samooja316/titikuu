using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raketti : MonoBehaviour
{

        public float moveSpeed;
    public float jumpHeight;
    private KeyCode lastHitKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Tämä koodin osa eli funktio suoritetaan useita kertoja sekunnissa
    // se päivittää pelin tilaa ja vastaanottaa käyttäjän komennot
    void Update()
    {
       if(Input.GetKeyDown (KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
        }

        if(Input.GetKeyDown (KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 0.009f);
        }

        if(Input.GetKeyDown (KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddTorque(-0.001f, ForceMode2D.Force); 
        }


        if(Input.GetKeyDown (KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddTorque(0.001f, ForceMode2D.Force);
        }
    }
        public void OnCollisionEnter2D(Collision2D kolari) {
          //  UnityEngine.SceneManagement.GetComponent<SceneManager>().LoadScene("testiplaneetta", LoadSceneMode.Additive);
          Application.LoadLevel("testiplaneetta");
        }        
    }

