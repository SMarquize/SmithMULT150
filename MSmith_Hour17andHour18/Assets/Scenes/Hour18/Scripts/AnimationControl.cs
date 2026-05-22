using UnityEngine;

public class AnimationControl : MonoBehaviour
{
Animator anim;
    void Start()
    {
    //Get a reference to the animator
    anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    anim.SetFloat("Speed", Input.GetAxis("Vertical"));
    anim.SetFloat("Direction", Input.GetAxis("Horizontal"));
    }

}
