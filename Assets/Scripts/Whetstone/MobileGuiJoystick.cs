/*using UnityEngine;

public class MobileGuiJoystick : GuiJoystick
{
    public MobileGuiJoystick(MoveJoystickVisual guiJoystickInstance, float radius, float globalScale, Rect inputArea, Vector2 holdPos) 
        : base(guiJoystickInstance, radius, globalScale, inputArea, holdPos)
    {
    }

    protected override void ManageMovementInternal(Vector2 pos)
    {
        var diff = pos.x - StartPos.x;
        var newPos = new Vector3(GuiJoystickInstance.transform.position.x, pos.y, 0);
        var edgeSize = (GuiJoystickInstance.ArrowWidth + GuiJoystickInstance.CirlceWidth / 2f) * GlobalScale;

        if (Mathf.Abs(diff) > edgeSize)
        {
            newPos.x = GuiJoystickInstance.transform.position.x + (Mathf.Abs(diff) - edgeSize) * Mathf.Sign(diff);
            StartPos = newPos;
        }
        GuiJoystickInstance.SetPosition(newPos);

        diff = Mathf.Clamp(diff, -edgeSize, edgeSize);
        GuiJoystickInstance.SetCirlePos(diff);

        Value = diff / edgeSize;
    }

    protected override void ManageTouchDownInternal(Vector2 newPos)
    {
        GuiJoystickInstance.SetPosition(newPos);
    }
}
*/
