/*using System;
using UnityEngine;

public class SkillJoystickVisual : MonoBehaviour, IDisposable
{
    public RepeatButton JumpButton;
    public RepeatButton Skill1Button;
    public RepeatButton Skill2Button;

    public event EventHandler JumpClicked;
    public event EventHandler Skill1Clicked;
    public event EventHandler Skill2Clicked;


    public void Start()
    {
        JumpButton.Pressed += JumpButtonOnPressed;
        Skill1Button.Pressed += Skill1ButtonOnPressed;
        Skill2Button.Pressed += Skill2ButtonOnPressed;
    }

    private void Skill2ButtonOnPressed()
    {
        Skill2Clicked.SafeInvoke(this, EventArgs.Empty);
    }

    private void Skill1ButtonOnPressed()
    {
        Skill1Clicked.SafeInvoke(this, EventArgs.Empty);
    }

    private void JumpButtonOnPressed()
    {
        JumpClicked.SafeInvoke(this, EventArgs.Empty);
    }

    public void Dispose()
    {
        JumpButton.Pressed -= JumpButtonOnPressed;
        Skill1Button.Pressed -= Skill1ButtonOnPressed;
        Skill2Button.Pressed -= Skill2ButtonOnPressed;

        JumpClicked = null;
        Skill1Clicked = null;
        Skill2Clicked = null;

        try
        {
            gameObject.SafeDestroy(); //BUG: missing reference even on getter. Find better way to solve such issues
        }
        catch (MissingReferenceException)
        {
        }
    }
}
*/