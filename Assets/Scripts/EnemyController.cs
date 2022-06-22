
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Transform followAt;
    public float distanceToFollow;
    public EnemySO data; 

    private NavMeshAgent mNavMeshAgent;
    private Animator mAnimator;

    public float health;
    public float maxhealth;

    public GameObject healthbarUI;
    public Slider slider;

    private void Awake()
    {
        mNavMeshAgent = GetComponent<NavMeshAgent>();
        mAnimator = transform.Find("Mutant").GetComponent<Animator>();
    }

    private void Start()
    {
        mNavMeshAgent.speed = data.speed;
        health = maxhealth;
        slider.value = CalculateHealth();
    }

    private void Update()
    {
        slider.value = CalculateHealth();

        //mNavMeshAgent.destination = followAt.position;
        float distance = Vector3.Distance(transform.position, followAt.position);
        if (distance <= distanceToFollow)
        {
            mNavMeshAgent.isStopped = false;
            mNavMeshAgent.destination = followAt.position;
            mAnimator.SetTrigger("Walk");
        }
        else
        {
            mAnimator.SetTrigger("Stop");
            mNavMeshAgent.isStopped = true;
        }

        if(health < maxhealth)
        {
            healthbarUI.SetActive(true);
        }

        if(health > maxhealth)
        {
            health = maxhealth;
        }


    }

    public void TakeDamage(float amout)
    {
        health -= amout;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    float CalculateHealth()
    {
        return health / maxhealth;
    }

}
