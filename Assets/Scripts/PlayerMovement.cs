using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int energy = 100;
    public float speed = 5f;
    public bool gamePaused = false;
    public Rigidbody2D rb;

    public void Start()
    {
        StartCoroutine(EnergyDrain());
    }

    public void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(x, y, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }

    // Coroutine that decreases energy once per second while the game is not paused.
    private IEnumerator EnergyDrain()
    {
        while (true)
        {
            if (!gamePaused)
            {
                yield return new WaitForSeconds(1f);
                energy--;
            }
            else
            {
                // when paused, wait one frame and check again so we can resume later
                yield return null;
            }
        }
    }

    public void PollutionCollide()
    {
        energy -= 20;
    }
    
    public void ElectricityCollide()
    {
        energy += 20;
    }
}
