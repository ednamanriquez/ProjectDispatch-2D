using Unity.Cinemachine;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public class MapTransition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private CinemachineCamera targetCam;
    [SerializeField] Direction direction;
    [SerializeField] private float offsetDistance = 0.5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MovePlayerAcross(other.gameObject);
           
        }

        if (targetCam != null)
        {
            CamSwitcher switcher = FindAnyObjectByType<CamSwitcher>();

            if (switcher != null)
            {
                switcher.SwitchTo(targetCam);
            }
        }
    }

    private void MovePlayerAcross(GameObject player)
    {
        Vector2 offset = Vector2.zero;

        switch (direction)
        {
            case Direction.Up:
                offset = new Vector2(0, offsetDistance); 
                break;
            case Direction.Down:
                offset = new Vector2(0, -offsetDistance);
                break;
            case Direction.Left:
                offset = new Vector2(-offsetDistance, 0);
                break;
            case Direction.Right:
                offset = new Vector2(offsetDistance, 0);
                break;
        }

        player.transform.position = (Vector2)player.transform.position + offset;
    }
}
