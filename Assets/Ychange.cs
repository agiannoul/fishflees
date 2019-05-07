using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ychange : MonoBehaviour
{
    public GameObject player;
    public Text text;
    // Your audio clip
    public AudioClip MusicClip;
    
    // the component that Unity uses to play your clip
    public AudioSource MusicSource;
    int score;
    // Start is called before the first frame update
    bool playmusic = true;
    void Start()
    {
        MusicSource.clip = MusicClip;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.autoSimulation)
        {
            move();
        }
        if(transform.position.x > 5 && playmusic)
        {
            MusicSource.Play();
            playmusic = false;
            score++;
            text.text = score.ToString();
        }

    }
    // Update is called once per frame
    public void move()
    {
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-0.6f, player.transform.position.y, transform.position.z);

            playmusic = true;
        }
        transform.position = new Vector3(transform.position.x + 3 * Time.deltaTime, transform.position.y, transform.position.z);
        
    }
}
