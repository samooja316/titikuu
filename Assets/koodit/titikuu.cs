using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titikuu : MonoBehaviour
{

        public float moveSpeed;
    public float jumpHeight;
    private KeyCode lastHitKey;
    // Start is called before the first frame update
    Animation anim;
    bool tippui = true;
    void Start()
    {
        anim = GetComponent<Animation>(); 
     
    }

    // Tämä koodin osa eli funktio suoritetaan useita kertoja sekunnissa
    // se päivittää pelin tilaa ja vastaanottaa käyttäjän komennot
    void Update()
    {
       if(Input.GetKeyDown (KeyCode.Space))
        {
            if(tippui) {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
                tippui = false;
            }
        }

        if(Input.GetKeyDown (KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 0.007f);
        }

        if(Input.GetKey (KeyCode.D))
        {
         /*   if(lastHitKey == KeyCode.D)
            {

            }else
            {*/
                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
               // anim.Play();
                lastHitKey = KeyCode.D;
            //}
        }


        if(Input.GetKey (KeyCode.A))
        {
           /* if(lastHitKey == KeyCode.A)
            {

            }else*/
         //   {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
               // anim.Play();
                lastHitKey = KeyCode.A;
           // }
        }
    }

    public void OnCollisionEnter2D(Collision2D other) {
        tippui=true;
    }       
    }

