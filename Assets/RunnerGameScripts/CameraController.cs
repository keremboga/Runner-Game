using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public float smooth;
    public Animator animator;
    public Camera cameraObject; 
    public Transform target;
    public GameObject playerObject; 
    private Vector3 offset;
    public Vector3 cameraOffset; 

  
    void Start()
    {
        smooth = 2.5f;
        offset = cameraObject.transform.position - target.position; 
    }

    
    void LateUpdate()
    {
        cameraOffset = cameraObject.transform.position - target.position;

        Vector3 newPosition = new Vector3(cameraObject.transform.position.x, transform.position.y, offset.z + target.position.z);
        cameraObject.transform.position = newPosition;
        	if (isPlaying("Twerking"))
            {
                if(cameraOffset.y > 2f && cameraOffset.z < -2f)
                {
                    cameraObject.transform.position = Vector3.Lerp(cameraObject.transform.position, playerObject.transform.position, Time.deltaTime * smooth);
                }

            }
            if (isFinished("Twerking"))
            {

                SceneManager.LoadScene("GameOverPanel");
            }


        }

        public bool isPlaying(string animationName)
        {
            return animator.GetCurrentAnimatorStateInfo(0).IsName(animationName); 
        }

        public bool isFinished(string animationName)
        {
            return animator.GetCurrentAnimatorStateInfo(0).IsName(animationName) && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f;

        }
        
    }


