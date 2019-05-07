using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2;
    public int velocity;
    public Text losetext;
    private bool end=false;
    // Your audio clip
    public AudioClip MusicClip;

    // the component that Unity uses to play your clip
    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(1, 2);
        MusicSource.clip = MusicClip;
        Physics2D.autoSimulation = true;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("TRAKARE");
        if (col.gameObject.tag == "obstackle")
        {

            losefunct();
        }
    }

    void losefunct()
    {
        losetext.text = "YOU LOSE";
        Physics2D.autoSimulation = false;
        end = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (end)
        {
            if (Input.GetKey("r") || Input.GetMouseButtonDown(0))
            {
                loadThisScene();
            }

        }
        
        if (Input.touchCount > 0)
        {
            move();
        }else if (Input.GetMouseButtonDown(0))
        {
            move();
        }

        if (rigidbody2.position.y <-6 && !end)
        {
            Debug.Log("TELOS");
            losefunct(); 
        }

       
    }

    public void loadThisScene()
    {
        SceneManager.LoadScene(1);
    }

   void move() {
        if (rigidbody2.velocity.y < 0)
        {
            MusicSource.Play();
            rigidbody2.AddForce(new Vector2(0, 10 * velocity * Time.deltaTime));
        }
        
    }
}
