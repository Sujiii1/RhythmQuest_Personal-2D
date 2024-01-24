using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyControll : MonoBehaviour
{
    //public Animator animator;
    private Movement2D player;
    [SerializeField] private  GameObject coin;
    [SerializeField] private  GameObject enemy_die;
    [SerializeField] private  GameObject puff_2;
    [SerializeField] private GameObject slash;
    public GameObject coin_spark;
    public GameObject puff_1;

    [SerializeField]float Time;
    [SerializeField] GameObject Effect;


    //Respawn
    public GameObject Player;
    public Transform respawnPoint;
    public float Speed;

    public PlayerManager playerManager ;

   // public float KnockbackForce = 2;


    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").TryGetComponent(out player);
    }

    private void Start()
    {
        playerManager = GetComponent<PlayerManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player.animator.GetCurrentAnimatorStateInfo(0).IsName("Attack")) // (0)Atteck을 하고 있는 중      (1) Attack을 끝난 상태
        {
            if (collision.transform.tag == "Player")
            {
                Instantiate(coin_spark, transform.position, Quaternion.identity);
                Instantiate(puff_1, transform.position, Quaternion.identity);
                StartCoroutine(controll_co(transform.position));
            }
        }
        else 
        {
            
            player.transform.position = respawnPoint.position;
            //playerManager.BackAudio();

        }

        //Enemy Double

        /*if(collision.gameObject.GetComponent<Enemy_double>())
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * KnockbackForce, ForceMode2D.Impulse);
            collision.gameObject.GetComponent<Enemy_double>().TakeDamage(damage);
            Destroy(gameObject);
        }*/
    }
  

    private IEnumerator controll_co(Vector3 position)
    {
        #region
        /* coin.transform.position = position;
         coin.SetActive(true);
         yield return new WaitForSeconds(Time);
         enemy_die.transform.position = position;
         enemy_die.SetActive(true);
         yield return new WaitForSeconds(Time);
         puff_2.transform.position = position;
         puff_2.SetActive(true);
         yield return new WaitForSeconds(Time);
         slash.transform.position = position;
         slash.SetActive(true);
         yield return new WaitForSeconds(Time*3f);
         coin.SetActive(false);
         enemy_die.SetActive(false);
         puff_2.SetActive(false);
         slash.SetActive(false);*/
        #endregion

        Effect.transform.position = position;
        Effect.SetActive(true);
        yield return new WaitForSeconds(Time);
        Effect.SetActive(false);
        yield return null;
        Destroy(gameObject);

    }

    


}
