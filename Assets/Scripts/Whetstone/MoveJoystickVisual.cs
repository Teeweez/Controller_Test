using UnityEngine;

public class MoveJoystickVisual : MonoBehaviour
{
    private float _radius;
    private float _returningVelocity;
    private Vector3 _desiredPos;

    public float ArrowWidth
    {
        get
        {
            return LeftArrow.sizeDelta.x * _radius;
        }
    }

    public float CirlceWidth
    {
        get
        {
            return JoystickCenter.sizeDelta.x;
        }
    }

    public RectTransform JoystickCenter;
    public RectTransform LeftArrow;
    public RectTransform RightArrow;

    public void SetRadius(float radius)
    {
        _radius = radius;

        LeftArrow.localScale *= _radius;
        RightArrow.localScale *= _radius;
    }

    public void SetCirlePos(float xPos)
    {
        JoystickCenter.position = new Vector3(transform.position.x + xPos, transform.position.y, 0);
    }

    public void SetPosition(Vector3 position, float returningVelocity = 100f)
    {
        _returningVelocity = returningVelocity;
        _desiredPos = position;
    }

    public void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _desiredPos, Time.deltaTime * _returningVelocity);
    }
}

