using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaCombat : MonoBehaviour
{
    private Animator anim;
    public int noOfLClicks = 0;
    public int noOfRClicks = 0;
    float lastClickedTime = 0;
    float maxComboDelay = 1.5f;
    public bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastClickedTime > maxComboDelay)
        {
            noOfLClicks = 0;
            noOfRClicks = 0;
            anim.SetBool("LAtk1", false);
            anim.SetBool("HAtk9", false);
            anim.SetBool("HAtk1", false);
        }

        //left clicks
        if(Input.GetMouseButtonDown(0))
        {
            lastClickedTime = Time.time;
            noOfLClicks++;
            if(noOfLClicks == 1)
            {
                anim.SetBool("LAtk1", true);
            }
            noOfLClicks = Mathf.Clamp(noOfLClicks, 0, 5);
        }

        //right clicks
        if (Input.GetMouseButtonDown(1))
        {
            lastClickedTime = Time.time;
            noOfRClicks++;
            if (noOfRClicks == 1 && noOfLClicks == 1)
            {
                anim.SetBool("HAtk4", true);
            }
            if(noOfRClicks == 1)
            {
                anim.SetBool("HAtk1", true);
            }
            noOfRClicks = Mathf.Clamp(noOfRClicks, 0, 5);
        }


        if (noOfLClicks == 0 && noOfRClicks == 0)
        {
            isAttacking = false;
        }
        else
        {
            isAttacking = true;
        }
    }
    public void returnLatk1()
    {
        if(noOfLClicks >= 2)
        {
            anim.SetBool("LAtk2", true);
            if(noOfRClicks == 1)
            {
                anim.SetBool("HAtk6", true);
            }
        }
        else
        {
            anim.SetBool("LAtk2", false);
            anim.SetBool("LAtk1", false);
            noOfLClicks = 0;
        }
    }
    public void returnLatk2()
    {
        if (noOfLClicks >= 3)
        {
            anim.SetBool("LAtk3", true);
            if (noOfRClicks == 1)
            {
                anim.SetBool("HAtk9", true);
            }
        }
        else
        {
            anim.SetBool("LAtk3", false);
            anim.SetBool("LAtk2", false);
            anim.SetBool("HAtk9", false);
            noOfLClicks = 0;
        }
    }
    public void returnLatk3()
    {
        if (noOfLClicks >= 4)
        {
            anim.SetBool("LAtk4", true);
        }
        else
        {
            anim.SetBool("LAtk4", false);
            anim.SetBool("LAtk3", false);
            noOfLClicks = 0;
        }
    }
    public void returnLatk4()
    {
        if (noOfLClicks >= 5)
        {
            anim.SetBool("LAtk5", true);
        }
        else
        {
            anim.SetBool("LAtk5", false);
            anim.SetBool("LAtk4", false);
            noOfLClicks = 0;
        }
    }
    public void returnLatk5()
    {
            anim.SetBool("LAtk1", false);
            anim.SetBool("LAtk2", false);
            anim.SetBool("LAtk3", false);
            anim.SetBool("LAtk4", false);
            anim.SetBool("LAtk5", false);
            noOfLClicks = 0;
    }
    public void returnHatk4()
    {
        if (noOfRClicks >= 2)
        {
            anim.SetBool("HAtk5", true);
        }
        else
        {
            anim.SetBool("HAtk5", false);
            anim.SetBool("HAtk4", false);
            noOfRClicks = 0;
        }
    }
    public void returnHatk5()
    {
        anim.SetBool("HAtk4", false);
        anim.SetBool("HAtk5", false);
        noOfRClicks = 0;
    }
    public void returnHatk6()
    {
        if (noOfRClicks >= 2)
        {
            anim.SetBool("HAtk7", true);
        }
        else
        {
            anim.SetBool("HAtk7", false);
            anim.SetBool("HAtk6", false);
            noOfRClicks = 0;
        }
    }
    public void returnHatk7()
    {
        if (noOfRClicks >= 3)
        {
            anim.SetBool("HAtk8", true);
        }
        else
        {
            anim.SetBool("HAtk8", false);
            anim.SetBool("HAtk7", false);
            noOfRClicks = 0;
        }
    }
    public void returnHatk8()
    {
        anim.SetBool("HAtk6", false);
        anim.SetBool("HAtk7", false);
        anim.SetBool("HAtk8", false);
        noOfRClicks = 0;
    }
    public void returnHatk1()
    {
        if (noOfRClicks >= 2)
        {
            anim.SetBool("HAtk2", true);
        }
        else
        {
            anim.SetBool("HAtk2", false);
            anim.SetBool("HAtk1", false);
            noOfRClicks = 0;
        }
    }
    public void returnHatk2()
    {
        if (noOfRClicks >= 3)
        {
            anim.SetBool("HAtk3", true);
        }
        else
        {
            anim.SetBool("HAtk3", false);
            anim.SetBool("HAtk2", false);
            noOfRClicks = 0;
        }
    }
    public void returnHatk3()
    {
        anim.SetBool("HAtk1", false);
        anim.SetBool("HAtk2", false);
        anim.SetBool("HAtk3", false);
        noOfRClicks = 0;
    }
}
