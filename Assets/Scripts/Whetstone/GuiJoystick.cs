/*using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class GuiJoystick : IDisposable
{
    protected Vector2 StartPos;
    private int _fingerId;
    private Rect _inputArea;
    private readonly Vector2 _holdPos;
    protected readonly MoveJoystickVisual GuiJoystickInstance;
    protected readonly float GlobalScale;

    public bool IsActive { get; private set; }

    public float Value
    {
        get;
        protected set;
    }

    public float HalfWidth
    {
        get
        {
            return GuiJoystickInstance.ArrowWidth + GuiJoystickInstance.CirlceWidth/2f;
        }
    }

    public GuiJoystick(MoveJoystickVisual guiJoystickInstance, float radius, float globalScale, Rect inputArea, Vector2 holdPos)
    {
        GuiJoystickInstance = guiJoystickInstance;
        GuiJoystickInstance.SetRadius(radius);
        GuiJoystickInstance.SetPosition(holdPos);

        GlobalScale = globalScale;
        _inputArea = inputArea;
        _holdPos = holdPos;

        GestureController.Instance.TouchDown += OnTouchDown;
        GestureController.Instance.Move += OnFingerMove;
        GestureController.Instance.TouchUp += OnTouchUp;
    }

    public void Dispose()
    {
        GestureController.Instance.TouchDown -= OnTouchDown;
        GestureController.Instance.Move -= OnFingerMove;
        GestureController.Instance.TouchUp -= OnTouchUp;

        if (GuiJoystickInstance != null)
        {
            Object.Destroy(GuiJoystickInstance.gameObject);
        }
    }

    private void OnTouchUp(object sender, TouchEventArgs e)
    {
        if (IsActive && e.FingerId == _fingerId)
        {
            GuiJoystickInstance.SetPosition(_holdPos, 10);
            GuiJoystickInstance.SetCirlePos(0);

            IsActive = false;
        }
    }

    protected virtual void ManageMovementInternal(Vector2 pos)
    {
        var diff = pos.x - StartPos.x;
        var edgeSize = GetVisualWidthDiv2();

        diff = Mathf.Clamp(diff, -edgeSize, edgeSize);
        GuiJoystickInstance.SetCirlePos(diff);

        Value = diff / edgeSize;

        GuiJoystickInstance.SetPosition(new Vector3(GuiJoystickInstance.transform.position.x, pos.y, 0));
    }

    protected virtual void ManageTouchDownInternal(Vector2 newPos)
    {
        var pos = new Vector3(GuiJoystickInstance.transform.position.x, newPos.y, 0);

        GuiJoystickInstance.SetPosition(pos, 20);
        StartPos = pos;

        ManageMovementInternal(pos);
    }

    protected float GetVisualWidthDiv2()
    {
        return (GuiJoystickInstance.ArrowWidth + GuiJoystickInstance.CirlceWidth / 2f) * GlobalScale;
    }

    private void OnFingerMove(object sender, TouchEventArgs e)
    {
        if (IsActive && e.FingerId == _fingerId)
        {
            ManageMovementInternal(e.Position);
        }
    }

    private void OnTouchDown(object sender, TouchEventArgs e)
    {
        if (!IsActive && _inputArea.Contains(e.Position))
        {
            _fingerId = e.FingerId;
            StartPos = e.Position;

            ManageTouchDownInternal(e.Position);
            
            IsActive = true;
        }
    }
}
*/