using UnityEngine;
using UnityEngine.AI;

public class GhostBehavior : MonoBehaviour
{
    public Transform player; // Player objesi (Pac-Man)
    public Transform[] patrolPoints; // Patrol yapacaðý noktalar
    private NavMeshAgent agent;
    private bool isChasing = false;
    public float chaseRadius = 0.5f; // Chase'in devreye gireceði yarýçap
    private float chaseDuration = 10f; // Chase süresi
    private float chaseTimer = 0f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GotoNextPoint();
    }

    void Update()
    {
        // Oyuncu ve hayalet arasýndaki mesafeyi hesapla
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        if (!isChasing && distanceToPlayer <= chaseRadius)
        {
            // Oyuncu yakýndaysa chase baþlat
            StartChase();
        }

        if (isChasing)
        {
            // Chase modunda oyuncuyu takip et
            agent.destination = player.position;

            // Chase süresini kontrol et
            chaseTimer += Time.deltaTime;
            if (chaseTimer >= chaseDuration)
            {
                StopChase();
            }
        }
        else if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            // Chase dýþýnda patrol mekanizmasýný sürdür
            GotoNextPoint();
        }
    }

    void StartChase()
    {
        isChasing = true;
        chaseTimer = 0f; // Chase zamanlayýcýsýný sýfýrla
        Debug.Log("Chase started!");
    }

    void StopChase()
    {
        isChasing = false;
        GotoNextPoint();
        Debug.Log("Chase ended, returning to patrol.");
    }

    void GotoNextPoint()
    {
        if (patrolPoints.Length == 0) return;

        // Rastgele bir patrol noktasý seç
        agent.destination = patrolPoints[Random.Range(0, patrolPoints.Length)].position;
    }
    void OnDrawGizmosSelected()
    {
        // Chase radius'u görselleþtir (sadece seçili olduðunda)
        Gizmos.color = Color.red; // Çember rengi kýrmýzý olacak
        Gizmos.DrawWireSphere(transform.position, chaseRadius);
    }

}