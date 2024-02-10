using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtSlap : MonoBehaviour
{
    public float slapForce = 5f; // Force of the slap
    public Transform player; // The player who will be slapped
    public float slapRange = 2f; // Range within which the slap can occur

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Slap();
        }
    }

    void Slap()
    {
        // Check if the player is within slap range
        if (Vector3.Distance(transform.position, player.position) <= slapRange)
                {
                    // Apply the slap force
                    player.GetComponent<Rigidbody>().AddForce((player.position - transform.position).normalized * slapForce, ForceMode.Impulse);
                }
            }
        }
    
