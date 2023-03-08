using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovmentController : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;

    [SerializeField] private float forwardMovemntSpeed;

    [SerializeField] private float horizontalMovmentSpeed;

    [SerializeField] private float horiztontalLimitValue;


    private float newPositionX;

    void FixedUpdate()
    {
        SetHeroForwardHero();
        SetHeroHorizontalMovment();
    }


    private void SetHeroForwardHero()
    {
        //Belirtilen y�nde s�rekli olarak hareket etmesini sa�layan kod fixed kulan�ld� fixed da tan�mlanacak ��nk�
        transform.Translate(Vector3.down * forwardMovemntSpeed * Time.fixedDeltaTime);

    }
    
    private void SetHeroHorizontalMovment()
    {
        newPositionX = transform.position.x + heroInputController.HorizontalValue * horizontalMovmentSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horiztontalLimitValue, horiztontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
