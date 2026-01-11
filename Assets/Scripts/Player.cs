using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
            Debug.Log("Up Arrow has been pressed");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.up * _speed * Time.deltaTime);
            Debug.Log("Down Arrow has been pressed");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
            Debug.Log("Right Arrow has been pressed");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * _speed * Time.deltaTime);
            Debug.Log("Left Arrow has been pressed");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
            Debug.Log("Space Bar has been pressed");
            Debug.Log(_playerTransform.position);
        }
    }

    public void PlantSeed ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
            Debug.Log("Space Bar has been pressed");
        }
    }
}
