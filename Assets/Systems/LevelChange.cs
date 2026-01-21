using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public LevelManager levelManager;
    public GameObject leveltoactivate;
    public Transform spawnlocation;
    public bool transitionlocked = false;
    private GameObject player;
    private void Start()
    {
       levelManager = Ervice.Instance.levelmanager;
    }
    public void OnEnable()
    {
        transitionlocked = GetComponent<Collider2D>().OverlapPoint(player.transform.position);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Ervice.Instance.levelmanager.levelchange(spawnlocation, leveltoactivate);
        }
    }
}
