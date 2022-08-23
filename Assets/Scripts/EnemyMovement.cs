using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _nav;
    [SerializeField] private Transform _player;
    void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        _nav.SetDestination(_player.position);
    }
}