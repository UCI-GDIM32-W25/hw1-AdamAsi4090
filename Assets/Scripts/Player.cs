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
        //Sets the number of seeds left to the number of seeds
        _numSeedsLeft = _numSeeds;
        //Put the number of seeds and the current number of seeds planted into UI
        _plantCountUI.UpdateSeeds(_numSeedsLeft, 0);
    }

    private void Update()
    {
        //Moves the player up if W or up-arrow is pressed
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        //Moves the player down if S or down-arrow is pressed
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        //Moves the player left if S or left-arrow is pressed
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        //Moves the player right if D or right-arrow is pressed.
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        //Plants a seed if space is pressed, and the number of seeds doesn't equal 0
        if (Input.GetKey(KeyCode.Space) && _numSeedsLeft != 0)
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        Debug.Log("The plant has been planted!");
        //Instantiates the plant object into the world
        GameObject plant = Instantiate(_plantPrefab);
        //Decrements the amount of seeds left
        _numSeedsLeft--;
        //Increments the amount of seeds planted
        _numSeedsPlanted++;
        //Updates the UI
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
